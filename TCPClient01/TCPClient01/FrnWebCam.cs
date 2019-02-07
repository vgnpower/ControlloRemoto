using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCPClient01
{
    public partial class FrnWebCam : Form
    {
        Principale FrmPrincipale;

        public FrnWebCam(Principale _frmPrincipale)
        {
            InitializeComponent();
            FrmPrincipale = _frmPrincipale;
        }

        public void GetUpdateScreen(Image _img)
        {
            pictureBox1.BackgroundImage = _img;
        }

        private void iniziaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void iniziaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ottieniProcessiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Inizia")
            {
                this.Text = "Condivisione schermo - iniziata";
                FrmPrincipale.TrasmettiMex("!/getwebcam start " + toolStripTextBox1.Text);
                startToolStripMenuItem.Text = "Termina";
                startToolStripMenuItem.BackColor = Color.Green;
            }
            else
            {
                this.Text = "Condivisione schermo - terminata";
                FrmPrincipale.TrasmettiMex("!/getwebcam stop 1");
                startToolStripMenuItem.Text = "Inizia";
                startToolStripMenuItem.BackColor = Color.Red;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
