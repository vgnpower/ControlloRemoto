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
    public partial class ListaProcessi : Form
    {
        Principale FrmPrincipale;
        private string[] ListaProc;
        DataGridViewCell clickedCell;
        public ListaProcessi(Principale _frmPrincipale)
        {
            InitializeComponent();
            FrmPrincipale = _frmPrincipale;
            bunifuCustomDataGrid1.Columns.Clear();
            CreaColonne();
        }

        private void ottieniProcessiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipale.TrasmettiMex("!/getproc ");
        }
        
        public void CaricaProcessi(string _lstProc)
        {
            ListaProc = _lstProc.Split('\n');
            //GeneraRow();
        }

        public void CreaColonne()
        {
            bunifuCustomDataGrid1.Columns.Clear();
            string[] colonne = new string[4] { "Nome processo", "PID", "MachineName", "Data avvio" };
            //Crea colonne
            for (int i = 0; i < colonne.Length; i++)
            {
                bunifuCustomDataGrid1.Columns.Add(colonne[i], colonne[i]);
                bunifuCustomDataGrid1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void GeneraRow()
        {
            CreaColonne();
            //Popola tabella
            for (int i = 0; i < ListaProc.Length; i++)
            {
                string[] lstproc = ListaProc[i].Split('|');
                var row = new DataGridViewRow();
                for (int j = 0; j < lstproc.Length; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = lstproc[j] });
                }
                bunifuCustomDataGrid1.Rows.Add(row);
            }
        }

        private void terminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeProcesso = clickedCell.Value.ToString();
                FrmPrincipale.TrasmettiMex("!/killproc " + nomeProcesso);
                FrmPrincipale.TrasmettiMex("!/getproc ");
            }
            catch { }
        }

        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView view = (DataGridView)sender;
                if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
                    clickedCell = view.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            catch { }
        }

        private void bunImgBtnClose_Click(object sender, EventArgs e)
        {
            TransClose.HideSync(this);
            this.Close();
        }

        private void bunImgBtnMaximize_Click(object sender, EventArgs e)
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

        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}