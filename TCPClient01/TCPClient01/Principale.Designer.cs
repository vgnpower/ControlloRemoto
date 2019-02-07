namespace TCPClient01
{
    partial class Principale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principale));
            BunifuAnimatorNS.Animation animation20 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation17 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation16 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation19 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation18 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.bunImgBtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.bnFltBtnLog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnFltBtnTools = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnFltBtnChat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnFltBtnConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunImgBtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcBxLogo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sideBarAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tbConsole = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tileBtnWebCam = new Bunifu.Framework.UI.BunifuTileButton();
            this.tileBtnListProc = new Bunifu.Framework.UI.BunifuTileButton();
            this.tileBtnCondSchermo = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbPayload = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbServerPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbServerIP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TransOpenContent = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TransOpenForm = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TransClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxLogo)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
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
            this.TransOpenContent.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1029, 35);
            this.pnlHeader.TabIndex = 12;
            this.pnlHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransOpenContent.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
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
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(198, 24);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Controllo remoto client";
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlBox.Controls.Add(this.bunImgBtnMinimize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnMaximize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnClose);
            this.TransOpenContent.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.pnlControlBox.Location = new System.Drawing.Point(916, 0);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(111, 35);
            this.pnlControlBox.TabIndex = 11;
            // 
            // bunImgBtnMinimize
            // 
            this.bunImgBtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.TransOpenContent.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
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
            this.TransOpenContent.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
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
            this.TransOpenContent.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
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
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlSidebar.Controls.Add(this.bnFltBtnLog);
            this.pnlSidebar.Controls.Add(this.bnFltBtnTools);
            this.pnlSidebar.Controls.Add(this.bnFltBtnChat);
            this.pnlSidebar.Controls.Add(this.bnFltBtnConnect);
            this.pnlSidebar.Controls.Add(this.bunImgBtnMenu);
            this.pnlSidebar.Controls.Add(this.pcBxLogo);
            this.TransOpenContent.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 35);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(223, 488);
            this.pnlSidebar.TabIndex = 13;
            // 
            // bnFltBtnLog
            // 
            this.bnFltBtnLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFltBtnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFltBtnLog.BorderRadius = 0;
            this.bnFltBtnLog.ButtonText = "Log";
            this.bnFltBtnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransClose.SetDecoration(this.bnFltBtnLog, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bnFltBtnLog, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bnFltBtnLog, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bnFltBtnLog, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.bnFltBtnLog, BunifuAnimatorNS.DecorationType.None);
            this.bnFltBtnLog.DisabledColor = System.Drawing.Color.Gray;
            this.bnFltBtnLog.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFltBtnLog.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnFltBtnLog.Iconimage")));
            this.bnFltBtnLog.Iconimage_right = null;
            this.bnFltBtnLog.Iconimage_right_Selected = null;
            this.bnFltBtnLog.Iconimage_Selected = null;
            this.bnFltBtnLog.IconMarginLeft = 0;
            this.bnFltBtnLog.IconMarginRight = 0;
            this.bnFltBtnLog.IconRightVisible = true;
            this.bnFltBtnLog.IconRightZoom = 0D;
            this.bnFltBtnLog.IconVisible = true;
            this.bnFltBtnLog.IconZoom = 90D;
            this.bnFltBtnLog.IsTab = false;
            this.bnFltBtnLog.Location = new System.Drawing.Point(0, 205);
            this.bnFltBtnLog.Name = "bnFltBtnLog";
            this.bnFltBtnLog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnLog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bnFltBtnLog.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFltBtnLog.selected = false;
            this.bnFltBtnLog.Size = new System.Drawing.Size(223, 48);
            this.bnFltBtnLog.TabIndex = 17;
            this.bnFltBtnLog.Text = "Log";
            this.bnFltBtnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFltBtnLog.Textcolor = System.Drawing.Color.White;
            this.bnFltBtnLog.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFltBtnLog.Click += new System.EventHandler(this.bnFltBtnLog_Click);
            // 
            // bnFltBtnTools
            // 
            this.bnFltBtnTools.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFltBtnTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFltBtnTools.BorderRadius = 0;
            this.bnFltBtnTools.ButtonText = "Tools";
            this.bnFltBtnTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransClose.SetDecoration(this.bnFltBtnTools, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bnFltBtnTools, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bnFltBtnTools, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bnFltBtnTools, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.bnFltBtnTools, BunifuAnimatorNS.DecorationType.None);
            this.bnFltBtnTools.DisabledColor = System.Drawing.Color.Gray;
            this.bnFltBtnTools.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFltBtnTools.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnFltBtnTools.Iconimage")));
            this.bnFltBtnTools.Iconimage_right = null;
            this.bnFltBtnTools.Iconimage_right_Selected = null;
            this.bnFltBtnTools.Iconimage_Selected = null;
            this.bnFltBtnTools.IconMarginLeft = 0;
            this.bnFltBtnTools.IconMarginRight = 0;
            this.bnFltBtnTools.IconRightVisible = true;
            this.bnFltBtnTools.IconRightZoom = 0D;
            this.bnFltBtnTools.IconVisible = true;
            this.bnFltBtnTools.IconZoom = 90D;
            this.bnFltBtnTools.IsTab = false;
            this.bnFltBtnTools.Location = new System.Drawing.Point(0, 158);
            this.bnFltBtnTools.Name = "bnFltBtnTools";
            this.bnFltBtnTools.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnTools.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bnFltBtnTools.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFltBtnTools.selected = false;
            this.bnFltBtnTools.Size = new System.Drawing.Size(223, 48);
            this.bnFltBtnTools.TabIndex = 16;
            this.bnFltBtnTools.Text = "Tools";
            this.bnFltBtnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFltBtnTools.Textcolor = System.Drawing.Color.White;
            this.bnFltBtnTools.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFltBtnTools.Click += new System.EventHandler(this.bnFltBtnTools_Click);
            // 
            // bnFltBtnChat
            // 
            this.bnFltBtnChat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFltBtnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFltBtnChat.BorderRadius = 0;
            this.bnFltBtnChat.ButtonText = " Chat";
            this.bnFltBtnChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransClose.SetDecoration(this.bnFltBtnChat, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bnFltBtnChat, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bnFltBtnChat, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bnFltBtnChat, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.bnFltBtnChat, BunifuAnimatorNS.DecorationType.None);
            this.bnFltBtnChat.DisabledColor = System.Drawing.Color.Gray;
            this.bnFltBtnChat.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFltBtnChat.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnFltBtnChat.Iconimage")));
            this.bnFltBtnChat.Iconimage_right = null;
            this.bnFltBtnChat.Iconimage_right_Selected = null;
            this.bnFltBtnChat.Iconimage_Selected = null;
            this.bnFltBtnChat.IconMarginLeft = 0;
            this.bnFltBtnChat.IconMarginRight = 0;
            this.bnFltBtnChat.IconRightVisible = true;
            this.bnFltBtnChat.IconRightZoom = 0D;
            this.bnFltBtnChat.IconVisible = true;
            this.bnFltBtnChat.IconZoom = 90D;
            this.bnFltBtnChat.IsTab = false;
            this.bnFltBtnChat.Location = new System.Drawing.Point(0, 111);
            this.bnFltBtnChat.Name = "bnFltBtnChat";
            this.bnFltBtnChat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnChat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bnFltBtnChat.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFltBtnChat.selected = false;
            this.bnFltBtnChat.Size = new System.Drawing.Size(223, 48);
            this.bnFltBtnChat.TabIndex = 15;
            this.bnFltBtnChat.Text = " Chat";
            this.bnFltBtnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFltBtnChat.Textcolor = System.Drawing.Color.White;
            this.bnFltBtnChat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFltBtnChat.Click += new System.EventHandler(this.bnFltBtnChat_Click);
            // 
            // bnFltBtnConnect
            // 
            this.bnFltBtnConnect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFltBtnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFltBtnConnect.BorderRadius = 0;
            this.bnFltBtnConnect.ButtonText = " Connetti";
            this.bnFltBtnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransClose.SetDecoration(this.bnFltBtnConnect, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bnFltBtnConnect, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bnFltBtnConnect, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bnFltBtnConnect, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.bnFltBtnConnect, BunifuAnimatorNS.DecorationType.None);
            this.bnFltBtnConnect.DisabledColor = System.Drawing.Color.Gray;
            this.bnFltBtnConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFltBtnConnect.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnFltBtnConnect.Iconimage")));
            this.bnFltBtnConnect.Iconimage_right = null;
            this.bnFltBtnConnect.Iconimage_right_Selected = null;
            this.bnFltBtnConnect.Iconimage_Selected = null;
            this.bnFltBtnConnect.IconMarginLeft = 0;
            this.bnFltBtnConnect.IconMarginRight = 0;
            this.bnFltBtnConnect.IconRightVisible = true;
            this.bnFltBtnConnect.IconRightZoom = 0D;
            this.bnFltBtnConnect.IconVisible = true;
            this.bnFltBtnConnect.IconZoom = 90D;
            this.bnFltBtnConnect.IsTab = false;
            this.bnFltBtnConnect.Location = new System.Drawing.Point(0, 64);
            this.bnFltBtnConnect.Name = "bnFltBtnConnect";
            this.bnFltBtnConnect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtnConnect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bnFltBtnConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFltBtnConnect.selected = true;
            this.bnFltBtnConnect.Size = new System.Drawing.Size(223, 48);
            this.bnFltBtnConnect.TabIndex = 14;
            this.bnFltBtnConnect.Text = " Connetti";
            this.bnFltBtnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFltBtnConnect.Textcolor = System.Drawing.Color.White;
            this.bnFltBtnConnect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFltBtnConnect.Click += new System.EventHandler(this.bnFltBtn1_Click);
            // 
            // bunImgBtnMenu
            // 
            this.bunImgBtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunImgBtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.TransOpenContent.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunImgBtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("bunImgBtnMenu.Image")));
            this.bunImgBtnMenu.ImageActive = null;
            this.bunImgBtnMenu.Location = new System.Drawing.Point(180, 18);
            this.bunImgBtnMenu.Name = "bunImgBtnMenu";
            this.bunImgBtnMenu.Size = new System.Drawing.Size(37, 28);
            this.bunImgBtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunImgBtnMenu.TabIndex = 13;
            this.bunImgBtnMenu.TabStop = false;
            this.bunImgBtnMenu.Zoom = 10;
            this.bunImgBtnMenu.Click += new System.EventHandler(this.bunImgBtnMenu_Click);
            // 
            // pcBxLogo
            // 
            this.pcBxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBxLogo.BackgroundImage")));
            this.pcBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransOpenContent.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.pcBxLogo.Location = new System.Drawing.Point(4, 8);
            this.pcBxLogo.Name = "pcBxLogo";
            this.pcBxLogo.Size = new System.Drawing.Size(156, 50);
            this.pcBxLogo.TabIndex = 10;
            this.pcBxLogo.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // sideBarAnimator
            // 
            this.sideBarAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.sideBarAnimator.Cursor = null;
            animation20.AnimateOnlyDifferences = true;
            animation20.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.BlindCoeff")));
            animation20.LeafCoeff = 0F;
            animation20.MaxTime = 1F;
            animation20.MinTime = 0F;
            animation20.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.MosaicCoeff")));
            animation20.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation20.MosaicShift")));
            animation20.MosaicSize = 0;
            animation20.Padding = new System.Windows.Forms.Padding(0);
            animation20.RotateCoeff = 0F;
            animation20.RotateLimit = 0F;
            animation20.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.ScaleCoeff")));
            animation20.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.SlideCoeff")));
            animation20.TimeCoeff = 0F;
            animation20.TransparencyCoeff = 0F;
            this.sideBarAnimator.DefaultAnimation = animation20;
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tbConsole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransClose.SetDecoration(this.tbConsole, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.tbConsole, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.tbConsole, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbConsole, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tbConsole, BunifuAnimatorNS.DecorationType.None);
            this.tbConsole.ForeColor = System.Drawing.Color.Silver;
            this.tbConsole.Location = new System.Drawing.Point(1, 0);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbConsole.Size = new System.Drawing.Size(798, 429);
            this.tbConsole.TabIndex = 14;
            this.tbConsole.Visible = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tileBtnWebCam);
            this.pnlContent.Controls.Add(this.tileBtnListProc);
            this.pnlContent.Controls.Add(this.tileBtnCondSchermo);
            this.pnlContent.Controls.Add(this.tbPayload);
            this.pnlContent.Controls.Add(this.tbServerPort);
            this.pnlContent.Controls.Add(this.tbServerIP);
            this.pnlContent.Controls.Add(this.tbSend);
            this.pnlContent.Controls.Add(this.btnConnect);
            this.pnlContent.Controls.Add(this.tbConsole);
            this.TransOpenContent.SetDecoration(this.pnlContent, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.pnlContent, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlContent, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlContent, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.pnlContent, BunifuAnimatorNS.DecorationType.None);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(223, 35);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(806, 488);
            this.pnlContent.TabIndex = 15;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // tileBtnWebCam
            // 
            this.tileBtnWebCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tileBtnWebCam.color = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tileBtnWebCam.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tileBtnWebCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.tileBtnWebCam, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tileBtnWebCam, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tileBtnWebCam, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.tileBtnWebCam, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.tileBtnWebCam, BunifuAnimatorNS.DecorationType.None);
            this.tileBtnWebCam.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.tileBtnWebCam.ForeColor = System.Drawing.Color.White;
            this.tileBtnWebCam.Image = ((System.Drawing.Image)(resources.GetObject("tileBtnWebCam.Image")));
            this.tileBtnWebCam.ImagePosition = 20;
            this.tileBtnWebCam.ImageZoom = 50;
            this.tileBtnWebCam.LabelPosition = 41;
            this.tileBtnWebCam.LabelText = "WebCam";
            this.tileBtnWebCam.Location = new System.Drawing.Point(465, 158);
            this.tileBtnWebCam.Margin = new System.Windows.Forms.Padding(6);
            this.tileBtnWebCam.Name = "tileBtnWebCam";
            this.tileBtnWebCam.Size = new System.Drawing.Size(145, 134);
            this.tileBtnWebCam.TabIndex = 22;
            this.tileBtnWebCam.Visible = false;
            this.tileBtnWebCam.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // tileBtnListProc
            // 
            this.tileBtnListProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tileBtnListProc.color = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tileBtnListProc.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tileBtnListProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.tileBtnListProc, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tileBtnListProc, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tileBtnListProc, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.tileBtnListProc, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.tileBtnListProc, BunifuAnimatorNS.DecorationType.None);
            this.tileBtnListProc.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.tileBtnListProc.ForeColor = System.Drawing.Color.White;
            this.tileBtnListProc.Image = ((System.Drawing.Image)(resources.GetObject("tileBtnListProc.Image")));
            this.tileBtnListProc.ImagePosition = 20;
            this.tileBtnListProc.ImageZoom = 50;
            this.tileBtnListProc.LabelPosition = 41;
            this.tileBtnListProc.LabelText = "Lista Processi";
            this.tileBtnListProc.Location = new System.Drawing.Point(308, 158);
            this.tileBtnListProc.Margin = new System.Windows.Forms.Padding(6);
            this.tileBtnListProc.Name = "tileBtnListProc";
            this.tileBtnListProc.Size = new System.Drawing.Size(145, 134);
            this.tileBtnListProc.TabIndex = 21;
            this.tileBtnListProc.Visible = false;
            this.tileBtnListProc.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // tileBtnCondSchermo
            // 
            this.tileBtnCondSchermo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tileBtnCondSchermo.color = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tileBtnCondSchermo.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tileBtnCondSchermo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.tileBtnCondSchermo, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tileBtnCondSchermo, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tileBtnCondSchermo, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.tileBtnCondSchermo, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.tileBtnCondSchermo, BunifuAnimatorNS.DecorationType.None);
            this.tileBtnCondSchermo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.tileBtnCondSchermo.ForeColor = System.Drawing.Color.White;
            this.tileBtnCondSchermo.Image = ((System.Drawing.Image)(resources.GetObject("tileBtnCondSchermo.Image")));
            this.tileBtnCondSchermo.ImagePosition = 20;
            this.tileBtnCondSchermo.ImageZoom = 50;
            this.tileBtnCondSchermo.LabelPosition = 41;
            this.tileBtnCondSchermo.LabelText = "Condivisione schermo";
            this.tileBtnCondSchermo.Location = new System.Drawing.Point(151, 158);
            this.tileBtnCondSchermo.Margin = new System.Windows.Forms.Padding(6);
            this.tileBtnCondSchermo.Name = "tileBtnCondSchermo";
            this.tileBtnCondSchermo.Size = new System.Drawing.Size(145, 134);
            this.tileBtnCondSchermo.TabIndex = 20;
            this.tileBtnCondSchermo.Visible = false;
            this.tileBtnCondSchermo.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // tbPayload
            // 
            this.tbPayload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPayload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPayload.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TransOpenContent.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.tbPayload.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPayload.ForeColor = System.Drawing.Color.Silver;
            this.tbPayload.HintForeColor = System.Drawing.Color.Silver;
            this.tbPayload.HintText = "";
            this.tbPayload.isPassword = false;
            this.tbPayload.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbPayload.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPayload.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbPayload.LineThickness = 3;
            this.tbPayload.Location = new System.Drawing.Point(6, 436);
            this.tbPayload.Margin = new System.Windows.Forms.Padding(4);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Size = new System.Drawing.Size(548, 48);
            this.tbPayload.TabIndex = 19;
            this.tbPayload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPayload.Visible = false;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TransOpenContent.SetDecoration(this.tbServerPort, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.tbServerPort, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbServerPort, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tbServerPort, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.tbServerPort, BunifuAnimatorNS.DecorationType.None);
            this.tbServerPort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbServerPort.ForeColor = System.Drawing.Color.Silver;
            this.tbServerPort.HintForeColor = System.Drawing.Color.Silver;
            this.tbServerPort.HintText = "";
            this.tbServerPort.isPassword = false;
            this.tbServerPort.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbServerPort.LineIdleColor = System.Drawing.Color.Gray;
            this.tbServerPort.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbServerPort.LineThickness = 3;
            this.tbServerPort.Location = new System.Drawing.Point(395, 173);
            this.tbServerPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(120, 33);
            this.tbServerPort.TabIndex = 18;
            this.tbServerPort.Text = "23000";
            this.tbServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TransOpenContent.SetDecoration(this.tbServerIP, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.tbServerIP, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbServerIP, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tbServerIP, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this.tbServerIP, BunifuAnimatorNS.DecorationType.None);
            this.tbServerIP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbServerIP.ForeColor = System.Drawing.Color.Silver;
            this.tbServerIP.HintForeColor = System.Drawing.Color.Silver;
            this.tbServerIP.HintText = "";
            this.tbServerIP.isPassword = false;
            this.tbServerIP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbServerIP.LineIdleColor = System.Drawing.Color.Gray;
            this.tbServerIP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbServerIP.LineThickness = 3;
            this.tbServerIP.Location = new System.Drawing.Point(268, 173);
            this.tbServerIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(120, 33);
            this.tbServerIP.TabIndex = 17;
            this.tbServerIP.Text = "192.168.1.128";
            this.tbServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbSend
            // 
            this.tbSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tbSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSend.BorderRadius = 0;
            this.tbSend.ButtonText = "Invia";
            this.tbSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransClose.SetDecoration(this.tbSend, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.tbSend, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbSend, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.tbSend, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.tbSend, BunifuAnimatorNS.DecorationType.None);
            this.tbSend.DisabledColor = System.Drawing.Color.Gray;
            this.tbSend.Iconcolor = System.Drawing.Color.Transparent;
            this.tbSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbSend.Iconimage")));
            this.tbSend.Iconimage_right = null;
            this.tbSend.Iconimage_right_Selected = null;
            this.tbSend.Iconimage_Selected = null;
            this.tbSend.IconMarginLeft = 0;
            this.tbSend.IconMarginRight = 0;
            this.tbSend.IconRightVisible = true;
            this.tbSend.IconRightZoom = 0D;
            this.tbSend.IconVisible = true;
            this.tbSend.IconZoom = 90D;
            this.tbSend.IsTab = false;
            this.tbSend.Location = new System.Drawing.Point(561, 436);
            this.tbSend.Name = "tbSend";
            this.tbSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.tbSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(129)))), ((int)(((byte)(139)))));
            this.tbSend.OnHoverTextColor = System.Drawing.Color.White;
            this.tbSend.selected = false;
            this.tbSend.Size = new System.Drawing.Size(241, 48);
            this.tbSend.TabIndex = 16;
            this.tbSend.Text = "Invia";
            this.tbSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSend.Textcolor = System.Drawing.Color.Silver;
            this.tbSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSend.Visible = false;
            this.tbSend.Click += new System.EventHandler(this.tbSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.BorderRadius = 0;
            this.btnConnect.ButtonText = "Connetti";
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransClose.SetDecoration(this.btnConnect, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnConnect, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.btnConnect, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this.btnConnect, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenContent.SetDecoration(this.btnConnect, BunifuAnimatorNS.DecorationType.None);
            this.btnConnect.DisabledColor = System.Drawing.Color.Gray;
            this.btnConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConnect.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConnect.Iconimage")));
            this.btnConnect.Iconimage_right = null;
            this.btnConnect.Iconimage_right_Selected = null;
            this.btnConnect.Iconimage_Selected = null;
            this.btnConnect.IconMarginLeft = 0;
            this.btnConnect.IconMarginRight = 0;
            this.btnConnect.IconRightVisible = true;
            this.btnConnect.IconRightZoom = 0D;
            this.btnConnect.IconVisible = true;
            this.btnConnect.IconZoom = 90D;
            this.btnConnect.IsTab = false;
            this.btnConnect.Location = new System.Drawing.Point(268, 213);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnConnect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(129)))), ((int)(((byte)(139)))));
            this.btnConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConnect.selected = false;
            this.btnConnect.Size = new System.Drawing.Size(247, 48);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connetti";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Textcolor = System.Drawing.Color.Silver;
            this.btnConnect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.logoAnimator.Cursor = null;
            animation17.AnimateOnlyDifferences = true;
            animation17.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.BlindCoeff")));
            animation17.LeafCoeff = 0F;
            animation17.MaxTime = 1F;
            animation17.MinTime = 0F;
            animation17.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.MosaicCoeff")));
            animation17.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation17.MosaicShift")));
            animation17.MosaicSize = 0;
            animation17.Padding = new System.Windows.Forms.Padding(50);
            animation17.RotateCoeff = 1F;
            animation17.RotateLimit = 0F;
            animation17.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.ScaleCoeff")));
            animation17.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.SlideCoeff")));
            animation17.TimeCoeff = 0F;
            animation17.TransparencyCoeff = 1F;
            this.logoAnimator.DefaultAnimation = animation17;
            // 
            // TransOpenContent
            // 
            this.TransOpenContent.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.TransOpenContent.Cursor = null;
            animation16.AnimateOnlyDifferences = true;
            animation16.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.BlindCoeff")));
            animation16.LeafCoeff = 0F;
            animation16.MaxTime = 1F;
            animation16.MinTime = 0F;
            animation16.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.MosaicCoeff")));
            animation16.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation16.MosaicShift")));
            animation16.MosaicSize = 20;
            animation16.Padding = new System.Windows.Forms.Padding(30);
            animation16.RotateCoeff = 0F;
            animation16.RotateLimit = 0F;
            animation16.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.ScaleCoeff")));
            animation16.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation16.SlideCoeff")));
            animation16.TimeCoeff = 0F;
            animation16.TransparencyCoeff = 0F;
            this.TransOpenContent.DefaultAnimation = animation16;
            // 
            // TransOpenForm
            // 
            this.TransOpenForm.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.TransOpenForm.Cursor = null;
            animation19.AnimateOnlyDifferences = true;
            animation19.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.BlindCoeff")));
            animation19.LeafCoeff = 0F;
            animation19.MaxTime = 1F;
            animation19.MinTime = 0F;
            animation19.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.MosaicCoeff")));
            animation19.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation19.MosaicShift")));
            animation19.MosaicSize = 0;
            animation19.Padding = new System.Windows.Forms.Padding(0);
            animation19.RotateCoeff = 0F;
            animation19.RotateLimit = 0F;
            animation19.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.ScaleCoeff")));
            animation19.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.SlideCoeff")));
            animation19.TimeCoeff = 0F;
            animation19.TransparencyCoeff = 0F;
            this.TransOpenForm.DefaultAnimation = animation19;
            // 
            // TransClose
            // 
            this.TransClose.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.TransClose.Cursor = null;
            animation18.AnimateOnlyDifferences = true;
            animation18.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.BlindCoeff")));
            animation18.LeafCoeff = 0F;
            animation18.MaxTime = 1F;
            animation18.MinTime = 0F;
            animation18.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.MosaicCoeff")));
            animation18.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation18.MosaicShift")));
            animation18.MosaicSize = 0;
            animation18.Padding = new System.Windows.Forms.Padding(0);
            animation18.RotateCoeff = 0F;
            animation18.RotateLimit = 0F;
            animation18.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.ScaleCoeff")));
            animation18.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.SlideCoeff")));
            animation18.TimeCoeff = 0F;
            animation18.TransparencyCoeff = 0F;
            this.TransClose.DefaultAnimation = animation18;
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1029, 523);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.TransOpenForm.SetDecoration(this, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.TransOpenContent.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.TransClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principale";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxLogo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel pnlControlBox;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnClose;
        private System.Windows.Forms.Panel pnlSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton bnFltBtnTools;
        private Bunifu.Framework.UI.BunifuFlatButton bnFltBtnChat;
        private Bunifu.Framework.UI.BunifuFlatButton bnFltBtnConnect;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMenu;
        private System.Windows.Forms.PictureBox pcBxLogo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition sideBarAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbConsole;
        private System.Windows.Forms.Panel pnlContent;
        private Bunifu.Framework.UI.BunifuFlatButton tbSend;
        private Bunifu.Framework.UI.BunifuFlatButton btnConnect;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbServerPort;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbServerIP;
        private Bunifu.Framework.UI.BunifuFlatButton bnFltBtnLog;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPayload;
        private Bunifu.Framework.UI.BunifuTileButton tileBtnWebCam;
        private Bunifu.Framework.UI.BunifuTileButton tileBtnListProc;
        private Bunifu.Framework.UI.BunifuTileButton tileBtnCondSchermo;
        private BunifuAnimatorNS.BunifuTransition TransOpenContent;
        private BunifuAnimatorNS.BunifuTransition TransOpenForm;
        private BunifuAnimatorNS.BunifuTransition TransClose;
    }
}

