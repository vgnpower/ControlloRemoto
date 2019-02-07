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
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TCPServer01
{
    public partial class Principale : Form
    {
        static bool imgRicevuta = false;
        static bool primoavvio = true;
        static bool imgWebCamRicevuta = false;
        static bool webCamPrimoAvvio = true;
        TcpListener mTCPListener;
        TcpClient mTCPClient;
        byte[] mRx;
        string lastMexRecivedIP = "";
        private List<ClientNode> mlClientSocks;
        Utility ObjUtility = new Utility();
        FuncRemote ObjFuncRem;
        WebCam ObjWebCam = new WebCam();

        public Principale()
        {
            InitializeComponent();
            mlClientSocks = new List<ClientNode>(2);
            CheckForIllegalCrossThreadCalls = false;
            ObjFuncRem = new FuncRemote(this);
        }

        IPAddress findMyIPV4Address()
        {
            string strThisHostName = string.Empty;
            IPHostEntry thisHostDNSEntry = null;
            IPAddress[] allIPsOfThisHost = null;
            IPAddress ipv4Ret = null;

            try
            {
                strThisHostName = System.Net.Dns.GetHostName();
                thisHostDNSEntry = System.Net.Dns.GetHostEntry(strThisHostName);
                allIPsOfThisHost = thisHostDNSEntry.AddressList;

                for (int idx = allIPsOfThisHost.Length - 1; idx >= 0; idx--)
                {
                    if (allIPsOfThisHost[idx].AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipv4Ret = allIPsOfThisHost[idx];
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return ipv4Ret;
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            //IPAddress ipaddr;
            //try
            //{
            //    if (!int.TryParse(tbPort.Text, out int nPort))
            //    {
            //        nPort = 23000;
            //    }
            //    if (!IPAddress.TryParse(tbIPAddress.Text, out ipaddr))
            //    {
            //        MessageBox.Show("Invalid IP address supplied.");
            //        return;
            //    }

            //    mTCPListener = new TcpListener(ipaddr, nPort);
            //    mTCPListener.Start();
            //    mTCPListener.BeginAcceptTcpClient(onCompleteAcceptTcpClient, mTCPListener);
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        void onCompleteAcceptTcpClient(IAsyncResult iar)
        {
            TcpListener tcpl = (TcpListener)iar.AsyncState;
            TcpClient tclient = null;
            ClientNode cNode = null;

            try
            {
                tclient = tcpl.EndAcceptTcpClient(iar);
                printLine("Client connesso...");
                tcpl.BeginAcceptTcpClient(onCompleteAcceptTcpClient, tcpl);

                lock (mlClientSocks)
                {
                    mlClientSocks.Add((cNode = new ClientNode(tclient, new byte[512], new byte[512], tclient.Client.RemoteEndPoint.ToString(), true)));
                    lbClients.Items.Add(cNode.ToString());
                    lastMexRecivedIP = tclient.Client.RemoteEndPoint.ToString();

                    if (cNode.primaConnessione == true)
                    {
                        TrasmettiMex("!/screen " + Screen.PrimaryScreen.Bounds.Width + ";" + Screen.PrimaryScreen.Bounds.Height);
                        cNode.primaConnessione = false;
                    }
                }


                tclient.GetStream().BeginRead(cNode.Rx, 0, cNode.Rx.Length, new AsyncCallback(onCompleteReadFromTCPClientStream), tclient);

                //mRx = new byte[512];
                //mTCPClient.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromTCPClientStream, mTCPClient);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void onCompleteReadFromTCPClientStream(IAsyncResult iar)
        {
            TcpClient tcpc;
            int nCountReadBytes = 0;
            string strRecv;
            ClientNode cn = null;

            try
            {
                lock (mlClientSocks)//serve per evitare un deadlock
                {
                    tcpc = (TcpClient)iar.AsyncState;
                    cn = mlClientSocks.Find(x => x.strId == tcpc.Client.RemoteEndPoint.ToString());//Cerca su quale client effettuare la lettura dei dati
                    nCountReadBytes = tcpc.GetStream().EndRead(iar);//Ottengo il numero di byte da ricevere nella lettura

                    if (nCountReadBytes == 0)//byte=0 interruzione della connessione
                    {
                        MessageBox.Show("Client disconnesso.");
                        mlClientSocks.Remove(cn);
                        lbClients.Items.Remove(cn.ToString());
                        return;
                    }

                    strRecv = Encoding.ASCII.GetString(cn.Rx, 0, nCountReadBytes).Trim();
                    lastMexRecivedIP = cn.ToString();
                    printLine(/*DateTime.Now + " - " + cn.ToString() + ": " +*/ strRecv);
                    imgRicevuta = (strRecv == "<?endImg>") ? true : false;
                    imgWebCamRicevuta = (strRecv == "<?endWebcam>") ? true : false;
                    //imgRicevuta = true;
                    cn.Rx = new byte[512];
                    //Inizio una nuova lettura asincrona sui client connessi
                    tcpc.GetStream().BeginRead(cn.Rx, 0, cn.Rx.Length, new AsyncCallback(onCompleteReadFromTCPClientStream), tcpc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lock (mlClientSocks)
                {
                    printLine("Client disconnesso: " + cn.ToString());
                    mlClientSocks.Remove(cn);
                    lbClients.Items.Remove(cn.ToString());
                }

            }
        }

        public void printLine(string _strPrint)
        {
            tbConsoleOutput.Invoke(new Action<string>(doInvoke), _strPrint);
            buMtTxtBxLog.Invoke(new Action<string>(printAllLog), _strPrint);
        }
        public void printAllLog(string _print)
        {
            buMtTxtBxLog.Text = _print + Environment.NewLine + buMtTxtBxLog.Text;
        }
        public void doInvoke(string _strPrint)
        {
            if ((_strPrint[0] == '!') && (_strPrint[1] == '/'))
            {
                string comando = _strPrint.Substring(2);
                string[] appo = comando.Split(' ');

                comando = appo[0];

                switch (comando)
                {
                    case "cmd":
                        ObjFuncRem.AvviaCmd(_strPrint.Substring(6));
                        break;
                    case "getproc":
                        TrasmettiProcessi(ObjFuncRem.GetProcessi());
                        break;
                    case "killproc":
                        ObjFuncRem.ChiudiProcesso(_strPrint.Substring(11));
                        break;
                    case "getscreen":
                        ObjFuncRem.GetScreen(_strPrint.Substring(12), tmrScreenShot, ref imgRicevuta, ref primoavvio);
                        break;
                    case "setcoord":
                        ObjFuncRem.SetCoordCursore(_strPrint.Substring(11)/*, this.Cursor*/);
                        break;
                    case "setclick":
                        string[] appoCoord = _strPrint.Substring(11).Split(';');
                        int x = Convert.ToInt32(appoCoord[0]);
                        int y = Convert.ToInt32(appoCoord[1]);
                        ObjFuncRem.LeftMouseClick(x, y);
                        break;
                    case "keystroke":
                        try
                        {
                            ObjFuncRem.SetKeyStroke(_strPrint.Substring(12));
                        }
                        catch { };

                        break;
                    case "getwebcam":
                        ObjFuncRem.GetWebcam(_strPrint.Substring(12), tmrWebCam, ref imgWebCamRicevuta, ref webCamPrimoAvvio, ObjWebCam);
                        break;
                }

            }
            tbConsoleOutput.Text = _strPrint + Environment.NewLine + tbConsoleOutput.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void onCompleteWriteToClientStream(IAsyncResult iar)
        {
            try
            {
                TcpClient tcpc = (TcpClient)iar.AsyncState;
                tcpc.GetStream().EndWrite(iar);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindIPv4IP_Click(object sender, EventArgs e)
        {
            IPAddress ipa = null;
            ipa = findMyIPV4Address();

            if (ipa != null)
            {
                tbIPAddress.Text = ipa.ToString();
            }
        }

        private void btnFindIPv4IP_Click_1(object sender, EventArgs e)
        {
            IPAddress ipa = null;

            ipa = findMyIPV4Address();
            if (ipa != null)
            {
                tbIPAddress.Text = ipa.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbIPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        public void TrasmettiMex(string _mex)
        {
            if (lbClients.Items.Count <= 0) return;
            if (string.IsNullOrEmpty(_mex)) return;

            ClientNode cn = null;

            lock (mlClientSocks)
            {
                cn = mlClientSocks.Find(x => x.strId == /*lbClients.SelectedItem.ToString()*/ lastMexRecivedIP);
                cn.Tx = new byte[512];

                try
                {
                    if ((cn != null) && (cn.tclient != null) && (cn.tclient.Client.Connected))
                    {
                        cn.Tx = Encoding.ASCII.GetBytes(_mex);
                        cn.tclient.GetStream().BeginWrite(cn.Tx, 0, cn.Tx.Length, new AsyncCallback(onCompleteWriteToClientStream), cn.tclient);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void TrasmettiMex2(string _mex)
        {
            ClientNode cn = null;

            cn = mlClientSocks.Find(x => x.strId == lastMexRecivedIP);

            cn.Tx = new byte[512];

            try
            {
                if ((cn != null) && (cn.tclient != null) && (cn.tclient.Client.Connected))
                {
                    cn.Tx = Encoding.ASCII.GetBytes(_mex);
                    cn.tclient.GetStream().BeginWrite(cn.Tx, 0, cn.Tx.Length, new AsyncCallback(onCompleteWriteToClientStream), cn.tclient);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TrasmettiImmagine(Image _img)
        {
            ClientNode cn = null;
            cn = mlClientSocks.Find(x => x.strId == lastMexRecivedIP);
            if (cn != null)
                cn.Tx = new byte[512];

            try
            {
                if ((cn != null) && (cn.tclient != null) && (cn.tclient.Client.Connected))
                {//TODO creare un'intestazione per l'immagine e un byte che dichiare la fine di questa
                    ImageConverter imgConverter = new ImageConverter();
                    byte[] sendBytes = (byte[])imgConverter.ConvertTo(_img, typeof(byte[]));
                    cn.Tx = sendBytes;
                    byte[] appo = new byte[sendBytes.Length + 4];
                    Array.Copy(sendBytes, appo, sendBytes.Length);
                    //convertire 137 in string per vedere cosa mi da 
                    byte[] appo2 = new byte[4];
                    appo2 = Encoding.ASCII.GetBytes("PNG>");
                    appo[appo.Length - 1] = appo2[3];
                    appo[appo.Length - 2] = appo2[2];
                    appo[appo.Length - 3] = appo2[1];
                    appo[appo.Length - 4] = appo2[0];
                    cn.Tx = appo;
                    if ((imgRicevuta) | (primoavvio))
                    {
                        cn.tclient.GetStream().BeginWrite(cn.Tx, 0, cn.Tx.Length, new AsyncCallback(onCompleteWriteToClientStream), cn.tclient);
                        primoavvio = false;
                        imgRicevuta = false;
                    }
                }
                else
                {
                    tmrScreenShot.Stop();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TrasmettiWebCam(Image _img)
        {
            ClientNode cn = null;
            cn = mlClientSocks.Find(x => x.strId == lastMexRecivedIP);
            if (cn != null)
                cn.Tx = new byte[512];

            try
            {
                if ((cn != null) && (cn.tclient != null) && (cn.tclient.Client.Connected))
                {
                    ImageConverter imgConverter = new ImageConverter();
                    byte[] sendBytes = (byte[])imgConverter.ConvertTo(_img, typeof(byte[]));
                    cn.Tx = sendBytes;
                    byte[] appo = new byte[sendBytes.Length + 4];
                    Array.Copy(sendBytes, appo, sendBytes.Length);
                    
                    byte[] appo2 = new byte[4];
                    appo2 = Encoding.ASCII.GetBytes("WEB>");
                    appo[appo.Length - 1] = appo2[3];
                    appo[appo.Length - 2] = appo2[2];
                    appo[appo.Length - 3] = appo2[1];
                    appo[appo.Length - 4] = appo2[0];
                    cn.Tx = appo;
                    if ((imgWebCamRicevuta) | (webCamPrimoAvvio))
                    {
                        cn.tclient.GetStream().BeginWrite(cn.Tx, 0, cn.Tx.Length, new AsyncCallback(onCompleteWriteToClientStream), cn.tclient);
                        webCamPrimoAvvio = false;
                        imgWebCamRicevuta = false;
                    }
                }
                else
                {
                    tmrWebCam.Stop();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TrasmettiProcessi(string _Processi)
        {

            ClientNode cn = null;
            cn = mlClientSocks.Find(x => x.strId == lastMexRecivedIP);
            if (cn != null)
                cn.Tx = new byte[512];

            try
            {
                if ((cn != null) && (cn.tclient != null) && (cn.tclient.Client.Connected))
                {//TODO creare un'intestazione per l'immagine e un byte che dichiare la fine di questa
                    byte[] sendBytes = Encoding.ASCII.GetBytes(_Processi);
                    //cn.Tx = sendBytes;
                    byte[] appo = new byte[sendBytes.Length + 4];
                    Array.Copy(sendBytes, appo, sendBytes.Length);
                    //convertire 137 in string per vedere cosa mi da 
                    byte[] appo2 = Encoding.ASCII.GetBytes("PRC>");
                    for (int i = 0; i < appo2.Length; i++)
                    {
                        appo[appo.Length - (i + 1)] = appo2[appo2.Length - (i + 1)];
                    }
                    //appo[appo.Length - 1] = appo2[3];
                    //appo[appo.Length - 2] = appo2[2];
                    //appo[appo.Length - 3] = appo2[1];
                    //appo[appo.Length - 4] = appo2[0];
                    cn.Tx = appo;
                    cn.tclient.GetStream().BeginWrite(cn.Tx, 0, cn.Tx.Length, new AsyncCallback(onCompleteWriteToClientStream), cn.tclient);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Image immagine = Image.FromFile("E:\\Varie\\Robbe\\personal image\\varie\\drago rosso.png");
                TrasmettiImmagine(ObjUtility.CaptureScreen()/*immagine*/);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        #region Utility
        //byte[] ObjectToByteArray(object obj)
        //{
        //    if (obj == null)
        //        return null;
        //    BinaryFormatter bf = new BinaryFormatter();
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        bf.Serialize(ms, obj);
        //        return ms.ToArray();
        //    }
        //}
        #endregion

        #region FunzionalitàRemote
        //public void GetProcessi()
        //{
        //    string listaProcessi = "";

        //    foreach (Process processo in Process.GetProcesses())
        //    {
        //        if (processo != null)
        //        { 
        //            listaProcessi = listaProcessi + processo.ProcessName + '\n';            
        //        }
        //    }
        //    string[] ordinaProc = listaProcessi.Split('\n');
        //    Array.Sort(ordinaProc);
        //    listaProcessi = "";
        //    for(int i = 0; i < ordinaProc.Length; i++)
        //    {
        //        if(ordinaProc[i] != null)
        //        listaProcessi = listaProcessi + ordinaProc[i] + Environment.NewLine;
        //    }
        //    TrasmettiMex2(listaProcessi);
        //}

        //public void ChiudiProcesso(string _procKill)
        //{            //da verificare se il processo esiste realmente
        //    if(_procKill[_procKill.Length - 1] == '\n')
        //    _procKill = _procKill.Substring(0, (_procKill.Length - 1));

        //    foreach (Process processo in Process.GetProcessesByName(_procKill))
        //    {
        //        processo.Kill();
        //    }
        //    TrasmettiMex2(_procKill + " terminato!" + Environment.NewLine);
        //}

        //public void AvviaCmd(string _comando)
        //{            //fixare bug che l'invio delle " le codifica così: \"
        //    //_comando.Replace('\',' ');
        //    string appo = "";
        //    string[] cmdSenzaQuoteMarks = _comando.Split('"');
        //    //forse conviene usare il match
        //    if(_comando.Contains('"'))
        //    {
        //        //for(int i = 0; i < _comando.Length; i++)
        //        //{
        //        //    if((i == _comando.Length) && (_comando[i] != '"'))
        //        //    {
        //        //        appo = appo + _comando[i];
        //        //    }
        //        //    if((_comando[i] == '"') && (i<_comando.Length))
        //        //    {
        //        //        if(_comando[++i] != '"')
        //        //        {
        //        //            appo = appo + _comando[++i];
        //        //        }
        //        //    }
        //        //}
        //    }

        //    Process.Start("cmd", _comando);
        //}

        //public void GetScreen(string _comando)
        //{//start, stop e intervallo
        //    string[] appo = _comando.Split(' ');

        //    if(appo[0] == "start")
        //    {
        //        //TrasmettiImmagine(CaptureScreen());
        //        timer1.Interval = Convert.ToInt32(appo[1]);
        //        timer1.Start();
        //        ////TrasmettiMex2("Condivisione iniziata!");
        //    }
        //    else
        //    {
        //        timer1.Stop();
        //        imgRicevuta = false;
        //        primoavvio = true;
        //        //TrasmettiMex2("Condivisione terminata!");
        //    }
        //}

        //public void SetCoordCursore(string _comando)
        //{
        //    string[] appoCoord = _comando.Split(';');
        //    this.Cursor = new Cursor(Cursor.Current.Handle);
        //    Cursor.Position = new Point(Convert.ToInt32(appoCoord[0]), Convert.ToInt32(appoCoord[1]));
        //}
        #endregion

        private void tmrWebCam_Tick(object sender, EventArgs e)
        {
            try
            {
                TrasmettiWebCam(ObjWebCam.CaptureWebCam());
            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunImgBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunImgBtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void pnlHeader_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TrasmettiMex(tbPayload.Text + Environment.NewLine);
            printAllLog(tbPayload.Text + Environment.NewLine);
        }

        private void lbClients_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //Text color
                e.Graphics.FillRectangle(Brushes.MediumSpringGreen, e.Bounds);
            }
            using (SolidBrush b = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(lbClients.GetItemText(lbClients.Items[e.Index]), e.Font, b, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value)
            {
                IPAddress ipaddr;
                try
                {
                    if (!int.TryParse(tbPort.Text, out int nPort))
                    {
                        nPort = 23000;
                    }
                    if (!IPAddress.TryParse(tbIPAddress.Text, out ipaddr))
                    {
                        MessageBox.Show("Invalid IP address supplied.");
                        return;
                    }

                    mTCPListener = new TcpListener(ipaddr, nPort);
                    mTCPListener.Start();
                    mTCPListener.BeginAcceptTcpClient(onCompleteAcceptTcpClient, mTCPListener);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                mTCPListener.Stop();
            }
        }

        private void bnFltBtn1_Click(object sender, EventArgs e)
        {
            MostraNascondiPanelContent(false, false, false);
            bunifuTransition1.ShowSync(tbIPAddress);
            bunifuTransition1.ShowSync(tbPort);
            bunifuTransition1.ShowSync(bunifuSwitch1);
            bunifuTransition1.ShowSync(buFltBtnTrovaIp);
            MostraNascondiPanelContent(true, false, false);
        }

        private void bnFltBtn2_Click(object sender, EventArgs e)
        {
            MostraNascondiPanelContent(false, false, false);
            bunifuTransition1.ShowSync(tbConsoleOutput);
            bunifuTransition1.ShowSync(lbClients);
            bunifuTransition1.ShowSync(tbPayload);
            bunifuTransition1.ShowSync(btnSend);
            MostraNascondiPanelContent(false, true, false);
        }

        private void bnFltBtn3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(buMtTxtBxLog);
            MostraNascondiPanelContent(false,false,true);
        }

        private void MostraNascondiPanelContent(bool _LogIn, bool _chat, bool _log)
        {
            if(_LogIn)
            {
                tbIPAddress.Visible = true;
                tbPort.Visible = true;
                bunifuSwitch1.Visible = true;
                buFltBtnTrovaIp.Visible = true;
                tbPayload.Visible = false;
                btnSend.Visible = false;
                lbClients.Visible = false;
                tbConsoleOutput.Visible = false;
                buMtTxtBxLog.Visible = false;
            }
            else
            {
                if (_chat)
                {
                    tbIPAddress.Visible = false;
                    tbPort.Visible = false;
                    bunifuSwitch1.Visible = false;
                    buFltBtnTrovaIp.Visible = false;
                    tbPayload.Visible = true;
                    btnSend.Visible = true;
                    lbClients.Visible = true;
                    tbConsoleOutput.Visible = true;
                    buMtTxtBxLog.Visible = false;
                }
                else
                {
                    if (_log)
                    {
                        tbIPAddress.Visible = false;
                        tbPort.Visible = false;
                        bunifuSwitch1.Visible = false;
                        buFltBtnTrovaIp.Visible = false;
                        tbPayload.Visible = false;
                        btnSend.Visible = false;
                        lbClients.Visible = false;
                        tbConsoleOutput.Visible = false;
                        buMtTxtBxLog.Visible = true;
                    }
                    else
                    {
                        tbIPAddress.Visible = false;
                        tbPort.Visible = false;
                        bunifuSwitch1.Visible = false;
                        buFltBtnTrovaIp.Visible = false;
                        tbPayload.Visible = false;
                        btnSend.Visible = false;
                        lbClients.Visible = false;
                        tbConsoleOutput.Visible = false;
                        buMtTxtBxLog.Visible = false;
                    }
                }
            }
        }

        private void buFltBtnTrovaIp_Click(object sender, EventArgs e)
        {
            IPAddress ipa = null;
            ipa = findMyIPV4Address();

            if (ipa != null)
            {
                tbIPAddress.Text = ipa.ToString();
            }
        }
    }
}