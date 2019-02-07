namespace TCPClient01
{
    partial class ListaProcessi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProcessi));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.terminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ottieniProcessiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.bunImgBtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenuStrip = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TransClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).BeginInit();
            this.pnlMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(91)))));
            this.TransClose.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // terminaToolStripMenuItem
            // 
            this.terminaToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.terminaToolStripMenuItem.Name = "terminaToolStripMenuItem";
            this.terminaToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.terminaToolStripMenuItem.Text = "Termina";
            this.terminaToolStripMenuItem.Click += new System.EventHandler(this.terminaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransClose.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ottieniProcessiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(109, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ottieniProcessiToolStripMenuItem
            // 
            this.ottieniProcessiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ottieniProcessiToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ottieniProcessiToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.ottieniProcessiToolStripMenuItem.Name = "ottieniProcessiToolStripMenuItem";
            this.ottieniProcessiToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ottieniProcessiToolStripMenuItem.Text = "Ottieni processi";
            this.ottieniProcessiToolStripMenuItem.Click += new System.EventHandler(this.ottieniProcessiToolStripMenuItem_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.ContextMenuStrip = this.contextMenuStrip1;
            this.TransClose.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 60);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(618, 377);
            this.bunifuCustomDataGrid1.TabIndex = 2;
            this.bunifuCustomDataGrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuCustomDataGrid1_CellMouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Controls.Add(this.pnlControlBox);
            this.TransClose.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(618, 35);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransClose.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.TransClose.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(321, 24);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Controllo remoto client - lista processi";
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlBox.Controls.Add(this.bunImgBtnMinimize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnMaximize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnClose);
            this.TransClose.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.pnlControlBox.Location = new System.Drawing.Point(505, 0);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(111, 35);
            this.pnlControlBox.TabIndex = 11;
            // 
            // bunImgBtnMinimize
            // 
            this.bunImgBtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.TransClose.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.bunImgBtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bunImgBtnMinimize.Image")));
            this.bunImgBtnMinimize.ImageActive = null;
            this.bunImgBtnMinimize.Location = new System.Drawing.Point(0, 0);
            this.bunImgBtnMinimize.Name = "bunImgBtnMinimize";
            this.bunImgBtnMinimize.Size = new System.Drawing.Size(35, 35);
            this.bunImgBtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunImgBtnMinimize.TabIndex = 9;
            this.bunImgBtnMinimize.TabStop = false;
            this.bunImgBtnMinimize.Zoom = 10;
            this.bunImgBtnMinimize.Click += new System.EventHandler(this.bunImgBtnMinimize_Click);
            // 
            // bunImgBtnMaximize
            // 
            this.bunImgBtnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.TransClose.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.bunImgBtnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("bunImgBtnMaximize.Image")));
            this.bunImgBtnMaximize.ImageActive = null;
            this.bunImgBtnMaximize.Location = new System.Drawing.Point(36, 0);
            this.bunImgBtnMaximize.Name = "bunImgBtnMaximize";
            this.bunImgBtnMaximize.Size = new System.Drawing.Size(35, 35);
            this.bunImgBtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunImgBtnMaximize.TabIndex = 7;
            this.bunImgBtnMaximize.TabStop = false;
            this.bunImgBtnMaximize.Zoom = 10;
            this.bunImgBtnMaximize.Click += new System.EventHandler(this.bunImgBtnMaximize_Click);
            // 
            // bunImgBtnClose
            // 
            this.bunImgBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.bunImgBtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransClose.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
            this.bunImgBtnClose.ErrorImage = null;
            this.bunImgBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("bunImgBtnClose.Image")));
            this.bunImgBtnClose.ImageActive = null;
            this.bunImgBtnClose.InitialImage = null;
            this.bunImgBtnClose.Location = new System.Drawing.Point(71, 0);
            this.bunImgBtnClose.Name = "bunImgBtnClose";
            this.bunImgBtnClose.Size = new System.Drawing.Size(35, 35);
            this.bunImgBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunImgBtnClose.TabIndex = 8;
            this.bunImgBtnClose.TabStop = false;
            this.bunImgBtnClose.Zoom = 10;
            this.bunImgBtnClose.Click += new System.EventHandler(this.bunImgBtnClose_Click);
            // 
            // pnlMenuStrip
            // 
            this.pnlMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlMenuStrip.Controls.Add(this.menuStrip1);
            this.TransClose.SetDecoration(this.pnlMenuStrip, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuStrip.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuStrip.Name = "pnlMenuStrip";
            this.pnlMenuStrip.Size = new System.Drawing.Size(618, 24);
            this.pnlMenuStrip.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TransClose
            // 
            this.TransClose.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.TransClose.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.TransClose.DefaultAnimation = animation1;
            // 
            // ListaProcessi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(618, 439);
            this.Controls.Add(this.pnlMenuStrip);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.TransClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaProcessi";
            this.Text = "ListaProcessi";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).EndInit();
            this.pnlMenuStrip.ResumeLayout(false);
            this.pnlMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ottieniProcessiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terminaToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlMenuStrip;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlControlBox;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition TransClose;
    }
}