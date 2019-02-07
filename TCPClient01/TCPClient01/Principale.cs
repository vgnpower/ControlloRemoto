using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace TCPClient01
{
    public partial class Principale : Form
    {
        condivisioneSchermo CSChermo;
        ListaProcessi ListaProcessi;
        FileExplorerTransfer FrmFileExplorer;
        FrnWebCam FrmWebCam;
        TcpClient mTcpClient;
        byte[] mRx;
        public Int32 resAltezza, resLunghezza;
        public Principale()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbServerIP.Text) || string.IsNullOrEmpty(tbServerPort.Text))
                    return;
                if (!IPAddress.TryParse(tbServerIP.Text, out IPAddress ipa))
                {
                    MessageBox.Show("Please supply an IP Address.");
                    return;
                }

                if (!int.TryParse(tbServerPort.Text, out int nPort))
                    nPort = 23000;

                mTcpClient = new TcpClient();
                mTcpClient.BeginConnect(ipa, nPort, new AsyncCallback(onCompleteConnect), mTcpClient);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                btnConnect.Iconimage = Properties.Resources.Disconnected_96px;
            }
        }

        void onCompleteConnect(IAsyncResult iar)
        {
            TcpClient tcpc;

            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.EndConnect(iar);

                mRx = new byte[1000000];
                tcpc.GetStream().BeginRead(mRx, 0, mRx.Length, new AsyncCallback(onCompleteReadFromServerStream), tcpc);
                btnConnect.Iconimage = Properties.Resources.Connected_96px;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                btnConnect.Iconimage = Properties.Resources.Disconnected_96px;
            }
        }
        static int erroreimg = 0;
        void onCompleteReadFromServerStream(IAsyncResult iar)
        {
            TcpClient tcpc;
            int nCountBytesReceivedFromServer;
            //TODO creare un buffer che aspetta tutti i pacchetti dell'img e poi quando li ha letti tutti li carica
            try
            {
                lock (this)
                {
                    tcpc = (TcpClient)iar.AsyncState;
                    nCountBytesReceivedFromServer = tcpc.GetStream().EndRead(iar);
                    //int a = tcpc.ReceiveBufferSize;
                    if (nCountBytesReceivedFromServer == 0)
                    {
                        MessageBox.Show("Connessione interrotta.");
                        return;
                    }

                    string strReceived = Encoding.ASCII.GetString(mRx, 0, nCountBytesReceivedFromServer);
                    printLine(strReceived);

                    try
                    {
                        //ScreenDesktop
                        if ((mRx[1] == 80) && (mRx[2] == 78) && (mRx[3] == 71) && (mRx[nCountBytesReceivedFromServer - 4] == 80) && (mRx[nCountBytesReceivedFromServer - 3] == 78) && (mRx[nCountBytesReceivedFromServer - 2] == 71) && (mRx[nCountBytesReceivedFromServer - 1] == 62))
                        {
                            Image img = Image.FromStream(new MemoryStream(mRx, 0, nCountBytesReceivedFromServer));
                            CSChermo.GetUpdateScreen(img);
                            #region SalvaScreen
                            //pictureBox1.BackgroundImage = img;
                            ////errore xke no nfa attempo a finire di scrivere il file che già lo richiede uno nuovo
                            //if (!Directory.Exists("screen"))
                            //    Directory.CreateDirectory("screen");

                            //while (File.Exists(Directory.GetCurrentDirectory() + "\\screen\\SubmittedFile" + erroreimg + ".png"))
                            //{
                            //    erroreimg++;
                            //}

                            //Stream fileStream = File.OpenWrite(Directory.GetCurrentDirectory() + "\\screen\\SubmittedFile" + erroreimg + ".png");

                            //fileStream.Write(mRx, 0, nCountBytesReceivedFromServer);
                            //fileStream.Close();
#endregion
                            TrasmettiMex("<?endImg>");
                        }
                        //ScreenWebCam
                        if ((mRx[nCountBytesReceivedFromServer - 4] == 87) && (mRx[nCountBytesReceivedFromServer - 3] == 69) && (mRx[nCountBytesReceivedFromServer - 2] == 66) && (mRx[nCountBytesReceivedFromServer - 1] == 62))
                        {
                            Image img = Image.FromStream(new MemoryStream(mRx, 0, nCountBytesReceivedFromServer));
                            FrmWebCam.GetUpdateScreen(img);
                            TrasmettiMex("<?endWebcam>");
                        }
                        //ListaProcessi
                        if ((mRx[nCountBytesReceivedFromServer - 4] == 80) && (mRx[nCountBytesReceivedFromServer - 3] == 82) && (mRx[nCountBytesReceivedFromServer - 2] == 67) && (mRx[nCountBytesReceivedFromServer - 1] == 62))
                        {
                            ListaProcessi.CaricaProcessi(Encoding.ASCII.GetString(mRx, 0, nCountBytesReceivedFromServer - 4));
                            ListaProcessi.Invoke(new Action(ListaProcessi.GeneraRow));
                        }

                        //if ((mRx[nCountBytesReceivedFromServer - 4] == 80) && (mRx[nCountBytesReceivedFromServer - 3] == 78) && (mRx[nCountBytesReceivedFromServer - 2] == 71) && (mRx[nCountBytesReceivedFromServer - 1] == 62))
                        //{
                        //    Image img = Image.FromStream(new MemoryStream(mRx, 0, nCountBytesReceivedFromServer));
                        //    pictureBox1.BackgroundImage = img;
                        //    TrasmettiMex("<?endImg>");
                        //}

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    mRx = new byte[1000000];
                    tcpc.GetStream().BeginRead(mRx, 0, mRx.Length, new AsyncCallback(onCompleteReadFromServerStream), tcpc);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void printLine(string _strPrint)
        {
            tbConsole.Invoke(new Action<string>(doInvoke), _strPrint);
        }

        public void doInvoke(string _strPrint)
        {
            if ((_strPrint[0] == '!') && (_strPrint[1] == '/'))
            {
                string comando = _strPrint.Substring(2);
                int i = 0; string[] appo = comando.Split(' ');

                comando = appo[0];
                //if (comando == "getproc")
                //{
                //    if (_strPrint[_strPrint.Length - 1] == '\n')
                //    {
                //        string appo = "";
                //        for (int j = 0; j < _strPrint.Length - 1; j++)
                //        {
                //            appo = appo + _strPrint[j];
                //        }
                //        _strPrint = appo;
                //    }
                //}

                switch (comando)
                {
                    case "screen":
                        GetScreenResolution(_strPrint.Substring(9));
                        break;
                }               
            }
            else
            {
                tbConsole.Text = _strPrint + Environment.NewLine + tbConsole.Text;
            }
        }

        public void GetScreenResolution(string _stringa)
        {
            string[] dimensioni = _stringa.Split(';');
            resLunghezza = Convert.ToInt32(dimensioni[0]);
            resAltezza = Convert.ToInt32(dimensioni[1]);
            this.Text = "Client " + resLunghezza + "x" + resAltezza;
        }

        private void tbSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPayload.Text)) return;
            
            try
            {
                byte[] tx = Encoding.ASCII.GetBytes(tbPayload.Text);

                if ((mTcpClient != null) && (mTcpClient.Client.Connected))
                    mTcpClient.GetStream().BeginWrite(tx, 0, tx.Length, new AsyncCallback(onCompleteWriteToServer), mTcpClient);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        void onCompleteWriteToServer(IAsyncResult iar)
        {
            TcpClient tcpc;

            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.GetStream().EndWrite(iar);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void TrasmettiMex(string _messaggio)
        {
            byte[] tx;

            if (string.IsNullOrEmpty(_messaggio)) return;

            try
            {
                tx = Encoding.ASCII.GetBytes(_messaggio);

                if ((mTcpClient != null) && (mTcpClient.Client.Connected))
                    mTcpClient.GetStream().BeginWrite(tx, 0, tx.Length, new AsyncCallback(onCompleteWriteToServer), mTcpClient);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFileExplorer = new FileExplorerTransfer(this);
            FrmFileExplorer.Show();
        }

        private void listaProcessiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void webcamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void bunImgBtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void bunImgBtnClose_Click(object sender, EventArgs e)
        {
            TransClose.HideSync(this);
            this.Close();
        }

        private void bunImgBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunImgBtnMenu_Click(object sender, EventArgs e)
        {
            if (pnlSidebar.Width == 223)
            {
                logoAnimator.Hide(pcBxLogo);
                pnlSidebar.Visible = false;
                pnlSidebar.Width = 50;
                sideBarAnimator.ShowSync(pnlSidebar);
            }
            else
            {
                pnlSidebar.Visible = false;
                pnlSidebar.Width = 223;
                sideBarAnimator.ShowSync(pnlSidebar);
                logoAnimator.ShowSync(pcBxLogo);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            CSChermo = new condivisioneSchermo(this);
            TransOpenForm.ShowSync(CSChermo);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ListaProcessi = new ListaProcessi(this);
            TransOpenForm.ShowSync(ListaProcessi);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            FrmWebCam = new FrnWebCam(this);
            TransOpenForm.ShowSync(FrmWebCam);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void condivisioneSchermoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aggiungere un controllo che non mi fa aprire più di 1 form

        }

        private void bnFltBtn1_Click(object sender, EventArgs e)
        {
            MostraNascondiPanelContent(false, false, false, false);
            TransOpenContent.ShowSync(tbServerIP);
            TransOpenContent.ShowSync(tbServerPort);
            TransOpenContent.ShowSync(btnConnect);
            MostraNascondiPanelContent(true, false, false, false);
        }

        private void bnFltBtnChat_Click(object sender, EventArgs e)
        {
            MostraNascondiPanelContent(false, false, false, false);
            TransOpenContent.ShowSync(tbConsole);
            TransOpenContent.ShowSync(tbPayload);
            TransOpenContent.ShowSync(tbSend);
            MostraNascondiPanelContent(false, true, false, false);
        }

        private void bnFltBtnTools_Click(object sender, EventArgs e)
        {
            MostraNascondiPanelContent(false, false, false, false);
            TransOpenContent.ShowSync(tileBtnCondSchermo);
            TransOpenContent.ShowSync(tileBtnListProc);
            TransOpenContent.ShowSync(tileBtnWebCam);
            MostraNascondiPanelContent(false, false, true, false );
        }

        private void bnFltBtnLog_Click(object sender, EventArgs e)
        {
            MostraNascondiPanelContent(false, false, false, false);

            MostraNascondiPanelContent(false, false, false, true);
        }

        private void MostraNascondiPanelContent(bool _LogIn, bool _chat, bool _tools, bool _log)
        {
            if (_LogIn)
            {
                tbServerIP.Visible = true;
                tbServerPort.Visible = true;
                btnConnect.Visible = true;
                tbSend.Visible = false;
                tbPayload.Visible = false;
                tbConsole.Visible = false;
                tileBtnCondSchermo.Visible = false;
                tileBtnListProc.Visible = false;
                tileBtnWebCam.Visible = false;
            }
            else
            {
                if (_chat)
                {
                    tbServerIP.Visible = false;
                    tbServerPort.Visible = false;
                    btnConnect.Visible = false;
                    tbSend.Visible = true;
                    tbPayload.Visible = true;
                    tbConsole.Visible = true;
                    tileBtnCondSchermo.Visible = false;
                    tileBtnListProc.Visible = false;
                    tileBtnWebCam.Visible = false;
                }
                else
                {
                    if (_tools)
                    {
                        tbServerIP.Visible = false;
                        tbServerPort.Visible = false;
                        btnConnect.Visible = false;
                        tbSend.Visible = false;
                        tbPayload.Visible = false;
                        tbConsole.Visible = false;
                        tileBtnCondSchermo.Visible = true;
                        tileBtnListProc.Visible = true;
                        tileBtnWebCam.Visible = true;
                    }
                    else
                    {
                        if(_log)
                        {

                        }
                        else
                        {
                            tbServerIP.Visible = false;
                            tbServerPort.Visible = false;
                            btnConnect.Visible = false;
                            tbSend.Visible = false;
                            tbPayload.Visible = false;
                            tbConsole.Visible = false;
                            tileBtnCondSchermo.Visible = false;
                            tileBtnListProc.Visible = false;
                            tileBtnWebCam.Visible = false;
                        }
                    }
                }
            }
        }

    }
}