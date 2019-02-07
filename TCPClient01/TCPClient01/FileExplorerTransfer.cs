using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TCPClient01
{
    public partial class FileExplorerTransfer : Form
    {
        Principale FrmPrincipale;
        public FileExplorerTransfer(Principale _frmPrincipale)
        {
            InitializeComponent();
            FrmPrincipale = _frmPrincipale;
        }

        private void FileExplorerTransfer_Load(object sender, EventArgs e)
        {
            lastOpemDir = "";
            foreach (DriveInfo drv in DriveInfo.GetDrives())
            {
                if (drv.IsReady)
                {
                    TreeNode t2 = new TreeNode();
                    t2.Text = drv.Name;
                    t2.Nodes.Add("");
                    treeView1.Nodes.Add(t2);
                }
            }
        }

        string lastOpemDir;
        TreeNode lstPrntNd;
        TreeNode t = new TreeNode();
        TreeNode current;
        TreeNode parentnode;

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                parentnode = e.Node;
                lstPrntNd = e.Node;
                DirectoryInfo[] dirInfo;
                DirectoryInfo dr = new DirectoryInfo(parentnode.FullPath);
                parentnode.Nodes.Clear();
                foreach (DirectoryInfo dir in dr.GetDirectories())
                {
                    TreeNode node = new TreeNode();
                    node.Text = dir.Name;

                    dr = new DirectoryInfo(dir.FullName);

                    try
                    {
                        dirInfo = dr.GetDirectories();
                        if (dirInfo.Length > 0)
                        {
                            node.Nodes.Add("");
                        }
                    }
                    catch (Exception ecc) { }
                    parentnode.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }

        public void treeBefExp(string _cartella)
        {
            try
            {
                DirectoryInfo[] dirInfo;
                DirectoryInfo dr = new DirectoryInfo(/*treeView1.SelectedNode.FullPath*/_cartella);
                parentnode.Nodes.Clear();
                foreach (DirectoryInfo dir in dr.GetDirectories())
                {
                    TreeNode node = new TreeNode();
                    node.Text = dir.Name;

                    dr = new DirectoryInfo(dir.FullName);

                    try
                    {
                        dirInfo = dr.GetDirectories();
                        if (dirInfo.Length > 0)
                        {
                            node.Nodes.Add("");
                        }
                    }
                    catch (Exception ecc) { }
                    parentnode.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }

        private void AfterSelect(string _cartella)
        {
            try
            {
                var node = new TreeNode(_cartella);
                string path = current.FullPath + "\\" + _cartella;
                string[] Files = Directory.GetFiles(path);
                string[] Directories = Directory.GetDirectories(path);
                string[] subinfo = new string[3];
                lastOpemDir = path;
                listView1.Clear();
                listView1.Columns.Add("Name", 255);
                listView1.Columns.Add("Size", 100);
                listView1.Columns.Add("Type", 80);
                foreach (string Dname in Directories)
                {
                    subinfo[0] = GetFileName(Dname);
                    subinfo[1] = "";
                    subinfo[2] = "FOLDER";
                    ListViewItem DItems = new ListViewItem(subinfo);
                    listView1.Items.Add(DItems);
                }
                foreach (string Fname in Files)
                {
                    subinfo[0] = GetFileName(Fname);
                    subinfo[1] = GetSizeinfo(Fname);
                    subinfo[2] = GetTypeinfo(Fname);
                    ListViewItem FItems = new ListViewItem(subinfo);
                    listView1.Items.Add(FItems);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                current = e.Node;
                string path = current.FullPath;
                string[] Files = Directory.GetFiles(path);
                string[] Directories = Directory.GetDirectories(path);
                string[] subinfo = new string[3];
                lastOpemDir = path;
                listView1.Clear();
                listView1.Columns.Add("Name", 255);
                listView1.Columns.Add("Size", 100);
                listView1.Columns.Add("Type", 80);
                foreach (string Dname in Directories)
                {
                    subinfo[0] = GetFileName(Dname);
                    subinfo[1] = "";
                    subinfo[2] = "FOLDER";
                    ListViewItem DItems = new ListViewItem(subinfo);
                    listView1.Items.Add(DItems);
                }
                foreach (string Fname in Files)
                {
                    subinfo[0] = GetFileName(Fname);
                    subinfo[1] = GetSizeinfo(Fname);
                    subinfo[2] = GetTypeinfo(Fname);
                    ListViewItem FItems = new ListViewItem(subinfo);
                    listView1.Items.Add(FItems);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }
        public string GetFileName(string path)
        {
            int Nameindex = path.LastIndexOf('\\');
            return path.Substring(Nameindex + 1);
        }
        public string GetTypeinfo(string path)
        {
            int Typeindex = path.LastIndexOf('.');
            string FType;
            if (Typeindex != -1)
            {
                FType = path.Substring(Typeindex + 1);
                FType = FType.ToUpper();
                if (FType == "AVI" || FType == "3GP" || FType == "WMV")
                {
                    FType = "Video Clip";
                }
                else if (FType == "MP3")
                {
                    FType = "MP3 Format Sound";
                }
                return FType;
            }
            else
            {
                FType = "FILE";
                return FType;
            }
        }
        public string GetSizeinfo(string path)
        {
            FileInfo fi = new FileInfo(path);
            long size = fi.Length;
            string txtsize = "";
            if (size < 1024)
            {
                txtsize = "byte";
            }
            else if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Kb";
            }
            if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Mb";
            }
            if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Gb";
            }
            return size + " " + txtsize;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed & Coded by: Shady Ahmed El-Yaski\nEmail: Shady@elyaski.com\nv.1.5.0", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string nomeElmSelezionato = listView1.SelectedItems[0].Text;
            int eleSelezionato = listView1.SelectedItems[0].Index;
            string tipoFile = listView1.SelectedItems[0].SubItems[2].Text;
            TreeNode tn = new TreeNode();
            tn = parentnode;
            tn = parentnode.NextVisibleNode;
            while (nomeElmSelezionato != tn.Text)
            {
                tn = tn.NextVisibleNode;
            }
            //tn.Nodes.Add(nomeElmSelezionato);
            parentnode = tn;
            //treeView1.SelectedNode = tn.LastNode;
            if (tipoFile == "FOLDER")
            {
                treeBefExp(/*lastOpemDir + "\\" + nomeElmSelezionato*/parentnode.FullPath);
            }
        }
    }
}
