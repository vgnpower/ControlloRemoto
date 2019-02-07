namespace TCPClient01
{
    partial class condivisioneSchermo
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(condivisioneSchermo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keystrokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catturaMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlPic = new System.Windows.Forms.Panel();
            this.pnlMenuStrip = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.bunImgBtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TransClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlPic.SuspendLayout();
            this.pnlMenuStrip.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransClose.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 383);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TransClose.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiToolStripMenuItem,
            this.keystrokeToolStripMenuItem,
            this.catturaMouseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(224, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.chiudiToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.chiudiToolStripMenuItem.Text = "Inizia  ";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // keystrokeToolStripMenuItem
            // 
            this.keystrokeToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.keystrokeToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.keystrokeToolStripMenuItem.Name = "keystrokeToolStripMenuItem";
            this.keystrokeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.keystrokeToolStripMenuItem.Text = "keystroke";
            this.keystrokeToolStripMenuItem.Click += new System.EventHandler(this.keystrokeToolStripMenuItem_Click);
            // 
            // catturaMouseToolStripMenuItem
            // 
            this.catturaMouseToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.catturaMouseToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.catturaMouseToolStripMenuItem.Name = "catturaMouseToolStripMenuItem";
            this.catturaMouseToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.catturaMouseToolStripMenuItem.Text = "cattura mouse";
            this.catturaMouseToolStripMenuItem.Click += new System.EventHandler(this.catturaMouseToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.TransClose.SetDecoration(this.numericUpDown1, BunifuAnimatorNS.DecorationType.None);
            this.numericUpDown1.ForeColor = System.Drawing.Color.Silver;
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(224, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlPic
            // 
            this.pnlPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPic.Controls.Add(this.pictureBox1);
            this.TransClose.SetDecoration(this.pnlPic, BunifuAnimatorNS.DecorationType.None);
            this.pnlPic.Location = new System.Drawing.Point(0, 59);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Size = new System.Drawing.Size(757, 383);
            this.pnlPic.TabIndex = 4;
            // 
            // pnlMenuStrip
            // 
            this.pnlMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlMenuStrip.Controls.Add(this.menuStrip1);
            this.pnlMenuStrip.Controls.Add(this.numericUpDown1);
            this.TransClose.SetDecoration(this.pnlMenuStrip, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuStrip.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuStrip.Name = "pnlMenuStrip";
            this.pnlMenuStrip.Size = new System.Drawing.Size(757, 24);
            this.pnlMenuStrip.TabIndex = 6;
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
            this.pnlHeader.Size = new System.Drawing.Size(757, 35);
            this.pnlHeader.TabIndex = 5;
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(291, 24);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Controllo remoto client - Schermo";
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlBox.Controls.Add(this.bunImgBtnMinimize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnMaximize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnClose);
            this.TransClose.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.pnlControlBox.Location = new System.Drawing.Point(644, 0);
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
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.TransClose.DefaultAnimation = animation4;
            // 
            // condivisioneSchermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(757, 443);
            this.Controls.Add(this.pnlMenuStrip);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlPic);
            this.TransClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "condivisioneSchermo";
            this.Text = "condivisioneSchermo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.condivisioneSchermo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlPic.ResumeLayout(false);
            this.pnlMenuStrip.ResumeLayout(false);
            this.pnlMenuStrip.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catturaMouseToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem keystrokeToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.Panel pnlMenuStrip;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel pnlControlBox;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition TransClose;
    }
}