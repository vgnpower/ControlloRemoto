using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TCPClient01
{
    public partial class condivisioneSchermo : Form
    {
        Principale FrmPrincipale;
        bool cursorOnPicbx = false;
        Single X, Y, oldX, oldY;

        public condivisioneSchermo(Principale _frmPrincipale)
        {
            InitializeComponent();
            FrmPrincipale = _frmPrincipale;
            X = 0;
            Y = 0;
        }

        public void GetUpdateScreen(Image _img)
        {
            pictureBox1.BackgroundImage = _img;
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(chiudiToolStripMenuItem.Text == "Inizia  ")
            {
                this.Text = "Condivisione schermo - iniziata";
                FrmPrincipale.TrasmettiMex("!/getscreen start " + numericUpDown1.Value);
                chiudiToolStripMenuItem.Text = "Ferma";
                chiudiToolStripMenuItem.BackColor = Color.Green;
            }
            else
            {
                this.Text = "Condivisione schermo - terminata";
                FrmPrincipale.TrasmettiMex("!/getscreen stop 1");
                chiudiToolStripMenuItem.Text = "Inizia  ";
                chiudiToolStripMenuItem.BackColor = Color.Red;
            }
        }

        private void condivisioneSchermo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipale.WindowState = FormWindowState.Normal;
        }

        private void catturaMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (catturaMouseToolStripMenuItem.BackColor == Color.Red)
            {
                timer1.Start();
                catturaMouseToolStripMenuItem.BackColor = Color.Green;
            }
            else
            {
                timer1.Stop();
                catturaMouseToolStripMenuItem.BackColor = Color.Red;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            cursorOnPicbx = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            cursorOnPicbx = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int cX = Cursor.Position.X;
            int cY = Cursor.Position.Y;
            if ((X != cX) && (Y != cY))
            {
                Single alt = (Single)FrmPrincipale.resAltezza / (Single)pictureBox1.Height;
                Single lung = (Single)FrmPrincipale.resLunghezza / (Single)pictureBox1.Width;
                
                Y = e.Y * alt;
                X = e.X * lung;
                cursorOnPicbx = true;
            }
            else
            {
                cursorOnPicbx = false;
            }

        }

        public void GetPicCursor()
        {
            int altSchermo = Screen.PrimaryScreen.Bounds.Height;
            int lungSchermo = Screen.PrimaryScreen.Bounds.Width;

            int coordXpic = pictureBox1.Width;
            int coordYpic = pictureBox1.Height;
        }

        private void keystrokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (keystrokeToolStripMenuItem.BackColor == Color.Red)
                keystrokeToolStripMenuItem.BackColor = Color.Green;
            else
                keystrokeToolStripMenuItem.BackColor = Color.Red;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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

        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int cX = Cursor.Position.X;
            int cY = Cursor.Position.Y;
            if ((cursorOnPicbx)&&(keystrokeToolStripMenuItem.BackColor == Color.Green))
            {
                Single alt = (Single)FrmPrincipale.resAltezza / (Single)pictureBox1.Height;
                Single lung = (Single)FrmPrincipale.resLunghezza / (Single)pictureBox1.Width;

                Y = e.Y * alt;
                X = e.X * lung;
                
                FrmPrincipale.TrasmettiMex("!/setclick " + Math.Round(X) + ";" + Math.Round(Y));
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(keystrokeToolStripMenuItem.BackColor == Color.Green)
                FrmPrincipale.TrasmettiMex("!/keystroke " + Convert.ToUInt64(e.KeyChar));          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((cursorOnPicbx) && ((oldX != X) || (oldY != Y)))
            {
                FrmPrincipale.TrasmettiMex("!/setcoord " + Math.Round(X) + ";" + Math.Round(Y));
                oldX = X;
                oldY = Y;
            }
        }
    }
}
