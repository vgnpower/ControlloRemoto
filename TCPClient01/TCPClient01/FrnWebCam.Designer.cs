namespace TCPClient01
{
    partial class FrnWebCam
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnWebCam));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.bunImgBtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TransClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMenuStrip = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).BeginInit();
            this.pnlMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransClose.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(0, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 420);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.pnlHeader.Size = new System.Drawing.Size(808, 35);
            this.pnlHeader.TabIndex = 4;
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(293, 24);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Controllo remoto client - WebCam";
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlBox.Controls.Add(this.bunImgBtnMinimize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnMaximize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnClose);
            this.TransClose.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.pnlControlBox.Location = new System.Drawing.Point(695, 0);
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
            // pnlMenuStrip
            // 
            this.pnlMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlMenuStrip.Controls.Add(this.menuStrip1);
            this.TransClose.SetDecoration(this.pnlMenuStrip, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuStrip.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuStrip.Name = "pnlMenuStrip";
            this.pnlMenuStrip.Size = new System.Drawing.Size(808, 24);
            this.pnlMenuStrip.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransClose.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.startToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.startToolStripMenuItem.Text = "Inizia";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.ottieniProcessiToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.White;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "500";
            // 
            // FrnWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(808, 485);
            this.Controls.Add(this.pnlMenuStrip);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pictureBox1);
            this.TransClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrnWebCam";
            this.Text = "FrnWebCam";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).EndInit();
            this.pnlMenuStrip.ResumeLayout(false);
            this.pnlMenuStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel pnlControlBox;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition TransClose;
        private System.Windows.Forms.Panel pnlMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}