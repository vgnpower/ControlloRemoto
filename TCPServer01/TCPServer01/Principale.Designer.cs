namespace TCPServer01
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.tmrScreenShot = new System.Windows.Forms.Timer(this.components);
            this.tmrWebCam = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLogInContent = new System.Windows.Forms.Panel();
            this.buMtTxtBxLog = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbConsoleOutput = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbPayload = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbIPAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.buFltBtnTrovaIp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.bnFltBtn3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnFltBtn2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnFltBtn1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunImgBtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcBxLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.bunImgBtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunImgBtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sideBarAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlLogInContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClients
            // 
            this.lbClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideBarAnimator.SetDecoration(this.lbClients, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.lbClients, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbClients, BunifuAnimatorNS.DecorationType.None);
            this.lbClients.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.lbClients.ForeColor = System.Drawing.Color.White;
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 37;
            this.lbClients.Location = new System.Drawing.Point(517, 8);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(274, 298);
            this.lbClients.TabIndex = 9;
            this.lbClients.Visible = false;
            this.lbClients.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbClients_DrawItem);
            // 
            // tmrScreenShot
            // 
            this.tmrScreenShot.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrWebCam
            // 
            this.tmrWebCam.Tick += new System.EventHandler(this.tmrWebCam_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlLogInContent
            // 
            this.pnlLogInContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlLogInContent.Controls.Add(this.buMtTxtBxLog);
            this.pnlLogInContent.Controls.Add(this.tbConsoleOutput);
            this.pnlLogInContent.Controls.Add(this.tbPayload);
            this.pnlLogInContent.Controls.Add(this.tbPort);
            this.pnlLogInContent.Controls.Add(this.lbClients);
            this.pnlLogInContent.Controls.Add(this.tbIPAddress);
            this.pnlLogInContent.Controls.Add(this.btnSend);
            this.pnlLogInContent.Controls.Add(this.bunifuSwitch1);
            this.pnlLogInContent.Controls.Add(this.buFltBtnTrovaIp);
            this.logoAnimator.SetDecoration(this.pnlLogInContent, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlLogInContent, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnlLogInContent, BunifuAnimatorNS.DecorationType.None);
            this.pnlLogInContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogInContent.Location = new System.Drawing.Point(223, 35);
            this.pnlLogInContent.Name = "pnlLogInContent";
            this.pnlLogInContent.Size = new System.Drawing.Size(794, 652);
            this.pnlLogInContent.TabIndex = 10;
            // 
            // buMtTxtBxLog
            // 
            this.buMtTxtBxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buMtTxtBxLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buMtTxtBxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.buMtTxtBxLog, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.buMtTxtBxLog, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.buMtTxtBxLog, BunifuAnimatorNS.DecorationType.None);
            this.buMtTxtBxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buMtTxtBxLog.ForeColor = System.Drawing.Color.White;
            this.buMtTxtBxLog.Location = new System.Drawing.Point(0, 0);
            this.buMtTxtBxLog.Multiline = true;
            this.buMtTxtBxLog.Name = "buMtTxtBxLog";
            this.buMtTxtBxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.buMtTxtBxLog.Size = new System.Drawing.Size(794, 652);
            this.buMtTxtBxLog.TabIndex = 18;
            this.buMtTxtBxLog.Visible = false;
            // 
            // tbConsoleOutput
            // 
            this.tbConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsoleOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tbConsoleOutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.tbConsoleOutput, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.tbConsoleOutput, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbConsoleOutput, BunifuAnimatorNS.DecorationType.None);
            this.tbConsoleOutput.ForeColor = System.Drawing.Color.White;
            this.tbConsoleOutput.Location = new System.Drawing.Point(6, 8);
            this.tbConsoleOutput.Multiline = true;
            this.tbConsoleOutput.Name = "tbConsoleOutput";
            this.tbConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbConsoleOutput.Size = new System.Drawing.Size(504, 299);
            this.tbConsoleOutput.TabIndex = 16;
            this.tbConsoleOutput.Visible = false;
            // 
            // tbPayload
            // 
            this.tbPayload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPayload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPayload.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoAnimator.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tbPayload, BunifuAnimatorNS.DecorationType.None);
            this.tbPayload.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPayload.ForeColor = System.Drawing.Color.White;
            this.tbPayload.HintForeColor = System.Drawing.Color.White;
            this.tbPayload.HintText = "";
            this.tbPayload.isPassword = false;
            this.tbPayload.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbPayload.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPayload.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbPayload.LineThickness = 3;
            this.tbPayload.Location = new System.Drawing.Point(4, 314);
            this.tbPayload.Margin = new System.Windows.Forms.Padding(4);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Size = new System.Drawing.Size(506, 34);
            this.tbPayload.TabIndex = 15;
            this.tbPayload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPayload.Visible = false;
            // 
            // tbPort
            // 
            this.tbPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoAnimator.SetDecoration(this.tbPort, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbPort, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tbPort, BunifuAnimatorNS.DecorationType.None);
            this.tbPort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPort.ForeColor = System.Drawing.Color.White;
            this.tbPort.HintForeColor = System.Drawing.Color.Empty;
            this.tbPort.HintText = "";
            this.tbPort.isPassword = false;
            this.tbPort.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbPort.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPort.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbPort.LineThickness = 3;
            this.tbPort.Location = new System.Drawing.Point(153, 18);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(114, 34);
            this.tbPort.TabIndex = 17;
            this.tbPort.Text = "23000";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoAnimator.SetDecoration(this.tbIPAddress, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.tbIPAddress, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.tbIPAddress, BunifuAnimatorNS.DecorationType.None);
            this.tbIPAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbIPAddress.ForeColor = System.Drawing.Color.White;
            this.tbIPAddress.HintForeColor = System.Drawing.Color.Empty;
            this.tbIPAddress.HintText = "";
            this.tbIPAddress.isPassword = false;
            this.tbIPAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbIPAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.tbIPAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbIPAddress.LineThickness = 3;
            this.tbIPAddress.Location = new System.Drawing.Point(30, 18);
            this.tbIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(115, 34);
            this.tbIPAddress.TabIndex = 16;
            this.tbIPAddress.Text = "192.168.1.128";
            this.tbIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "Invia";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSend, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.btnSend, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnSend, BunifuAnimatorNS.DecorationType.None);
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSend.Iconimage")));
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 90D;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(517, 314);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(129)))), ((int)(((byte)(139)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(274, 34);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Invia";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuSwitch1, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunifuSwitch1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuSwitch1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(62, 78);
            this.bunifuSwitch1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkRed;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 15;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = false;
            this.bunifuSwitch1.Click += new System.EventHandler(this.bunifuSwitch1_Click);
            // 
            // buFltBtnTrovaIp
            // 
            this.buFltBtnTrovaIp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buFltBtnTrovaIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.buFltBtnTrovaIp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buFltBtnTrovaIp.BorderRadius = 0;
            this.buFltBtnTrovaIp.ButtonText = "Trova IP";
            this.buFltBtnTrovaIp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.buFltBtnTrovaIp, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.buFltBtnTrovaIp, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.buFltBtnTrovaIp, BunifuAnimatorNS.DecorationType.None);
            this.buFltBtnTrovaIp.DisabledColor = System.Drawing.Color.Gray;
            this.buFltBtnTrovaIp.Iconcolor = System.Drawing.Color.Transparent;
            this.buFltBtnTrovaIp.Iconimage = ((System.Drawing.Image)(resources.GetObject("buFltBtnTrovaIp.Iconimage")));
            this.buFltBtnTrovaIp.Iconimage_right = null;
            this.buFltBtnTrovaIp.Iconimage_right_Selected = null;
            this.buFltBtnTrovaIp.Iconimage_Selected = null;
            this.buFltBtnTrovaIp.IconMarginLeft = 0;
            this.buFltBtnTrovaIp.IconMarginRight = 0;
            this.buFltBtnTrovaIp.IconRightVisible = true;
            this.buFltBtnTrovaIp.IconRightZoom = 0D;
            this.buFltBtnTrovaIp.IconVisible = true;
            this.buFltBtnTrovaIp.IconZoom = 90D;
            this.buFltBtnTrovaIp.IsTab = false;
            this.buFltBtnTrovaIp.Location = new System.Drawing.Point(153, 59);
            this.buFltBtnTrovaIp.Name = "buFltBtnTrovaIp";
            this.buFltBtnTrovaIp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.buFltBtnTrovaIp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(129)))), ((int)(((byte)(139)))));
            this.buFltBtnTrovaIp.OnHoverTextColor = System.Drawing.Color.White;
            this.buFltBtnTrovaIp.selected = false;
            this.buFltBtnTrovaIp.Size = new System.Drawing.Size(114, 48);
            this.buFltBtnTrovaIp.TabIndex = 13;
            this.buFltBtnTrovaIp.Text = "Trova IP";
            this.buFltBtnTrovaIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buFltBtnTrovaIp.Textcolor = System.Drawing.Color.White;
            this.buFltBtnTrovaIp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buFltBtnTrovaIp.Click += new System.EventHandler(this.buFltBtnTrovaIp_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlSidebar.Controls.Add(this.bnFltBtn3);
            this.pnlSidebar.Controls.Add(this.bnFltBtn2);
            this.pnlSidebar.Controls.Add(this.bnFltBtn1);
            this.pnlSidebar.Controls.Add(this.bunImgBtnMenu);
            this.pnlSidebar.Controls.Add(this.pcBxLogo);
            this.logoAnimator.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 35);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(223, 652);
            this.pnlSidebar.TabIndex = 11;
            // 
            // bnFltBtn3
            // 
            this.bnFltBtn3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFltBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFltBtn3.BorderRadius = 0;
            this.bnFltBtn3.ButtonText = " Log";
            this.bnFltBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bnFltBtn3, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bnFltBtn3, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bnFltBtn3, BunifuAnimatorNS.DecorationType.None);
            this.bnFltBtn3.DisabledColor = System.Drawing.Color.Gray;
            this.bnFltBtn3.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFltBtn3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnFltBtn3.Iconimage")));
            this.bnFltBtn3.Iconimage_right = null;
            this.bnFltBtn3.Iconimage_right_Selected = null;
            this.bnFltBtn3.Iconimage_Selected = null;
            this.bnFltBtn3.IconMarginLeft = 0;
            this.bnFltBtn3.IconMarginRight = 0;
            this.bnFltBtn3.IconRightVisible = true;
            this.bnFltBtn3.IconRightZoom = 0D;
            this.bnFltBtn3.IconVisible = true;
            this.bnFltBtn3.IconZoom = 90D;
            this.bnFltBtn3.IsTab = false;
            this.bnFltBtn3.Location = new System.Drawing.Point(0, 158);
            this.bnFltBtn3.Name = "bnFltBtn3";
            this.bnFltBtn3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtn3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bnFltBtn3.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFltBtn3.selected = false;
            this.bnFltBtn3.Size = new System.Drawing.Size(223, 48);
            this.bnFltBtn3.TabIndex = 16;
            this.bnFltBtn3.Text = " Log";
            this.bnFltBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFltBtn3.Textcolor = System.Drawing.Color.White;
            this.bnFltBtn3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFltBtn3.Click += new System.EventHandler(this.bnFltBtn3_Click);
            // 
            // bnFltBtn2
            // 
            this.bnFltBtn2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFltBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFltBtn2.BorderRadius = 0;
            this.bnFltBtn2.ButtonText = " Chat";
            this.bnFltBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bnFltBtn2, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bnFltBtn2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bnFltBtn2, BunifuAnimatorNS.DecorationType.None);
            this.bnFltBtn2.DisabledColor = System.Drawing.Color.Gray;
            this.bnFltBtn2.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFltBtn2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnFltBtn2.Iconimage")));
            this.bnFltBtn2.Iconimage_right = null;
            this.bnFltBtn2.Iconimage_right_Selected = null;
            this.bnFltBtn2.Iconimage_Selected = null;
            this.bnFltBtn2.IconMarginLeft = 0;
            this.bnFltBtn2.IconMarginRight = 0;
            this.bnFltBtn2.IconRightVisible = true;
            this.bnFltBtn2.IconRightZoom = 0D;
            this.bnFltBtn2.IconVisible = true;
            this.bnFltBtn2.IconZoom = 90D;
            this.bnFltBtn2.IsTab = false;
            this.bnFltBtn2.Location = new System.Drawing.Point(0, 111);
            this.bnFltBtn2.Name = "bnFltBtn2";
            this.bnFltBtn2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtn2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bnFltBtn2.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFltBtn2.selected = false;
            this.bnFltBtn2.Size = new System.Drawing.Size(223, 48);
            this.bnFltBtn2.TabIndex = 15;
            this.bnFltBtn2.Text = " Chat";
            this.bnFltBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFltBtn2.Textcolor = System.Drawing.Color.White;
            this.bnFltBtn2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFltBtn2.Click += new System.EventHandler(this.bnFltBtn2_Click);
            // 
            // bnFltBtn1
            // 
            this.bnFltBtn1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bnFltBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnFltBtn1.BorderRadius = 0;
            this.bnFltBtn1.ButtonText = " Connetti";
            this.bnFltBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bnFltBtn1, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bnFltBtn1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bnFltBtn1, BunifuAnimatorNS.DecorationType.None);
            this.bnFltBtn1.DisabledColor = System.Drawing.Color.Gray;
            this.bnFltBtn1.Iconcolor = System.Drawing.Color.Transparent;
            this.bnFltBtn1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bnFltBtn1.Iconimage")));
            this.bnFltBtn1.Iconimage_right = null;
            this.bnFltBtn1.Iconimage_right_Selected = null;
            this.bnFltBtn1.Iconimage_Selected = null;
            this.bnFltBtn1.IconMarginLeft = 0;
            this.bnFltBtn1.IconMarginRight = 0;
            this.bnFltBtn1.IconRightVisible = true;
            this.bnFltBtn1.IconRightZoom = 0D;
            this.bnFltBtn1.IconVisible = true;
            this.bnFltBtn1.IconZoom = 90D;
            this.bnFltBtn1.IsTab = false;
            this.bnFltBtn1.Location = new System.Drawing.Point(0, 64);
            this.bnFltBtn1.Name = "bnFltBtn1";
            this.bnFltBtn1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bnFltBtn1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bnFltBtn1.OnHoverTextColor = System.Drawing.Color.White;
            this.bnFltBtn1.selected = true;
            this.bnFltBtn1.Size = new System.Drawing.Size(223, 48);
            this.bnFltBtn1.TabIndex = 14;
            this.bnFltBtn1.Text = " Connetti";
            this.bnFltBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnFltBtn1.Textcolor = System.Drawing.Color.White;
            this.bnFltBtn1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFltBtn1.Click += new System.EventHandler(this.bnFltBtn1_Click);
            // 
            // bunImgBtnMenu
            // 
            this.bunImgBtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunImgBtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.logoAnimator.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunImgBtnMenu, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuTransition1.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pcBxLogo, BunifuAnimatorNS.DecorationType.None);
            this.pcBxLogo.Location = new System.Drawing.Point(4, 8);
            this.pcBxLogo.Name = "pcBxLogo";
            this.pcBxLogo.Size = new System.Drawing.Size(156, 50);
            this.pcBxLogo.TabIndex = 10;
            this.pcBxLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Controls.Add(this.pnlControlBox);
            this.logoAnimator.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1017, 35);
            this.pnlHeader.TabIndex = 12;
            this.pnlHeader.DoubleClick += new System.EventHandler(this.pnlHeader_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(38, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(209, 24);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Controllo remoto Server";
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlBox.Controls.Add(this.bunImgBtnMinimize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnMaximize);
            this.pnlControlBox.Controls.Add(this.bunImgBtnClose);
            this.logoAnimator.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnlControlBox, BunifuAnimatorNS.DecorationType.None);
            this.pnlControlBox.Location = new System.Drawing.Point(903, 1);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(111, 35);
            this.pnlControlBox.TabIndex = 10;
            // 
            // bunImgBtnMinimize
            // 
            this.bunImgBtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunImgBtnMinimize, BunifuAnimatorNS.DecorationType.None);
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
            this.logoAnimator.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunImgBtnMaximize, BunifuAnimatorNS.DecorationType.None);
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
            this.logoAnimator.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
            this.sideBarAnimator.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunImgBtnClose, BunifuAnimatorNS.DecorationType.None);
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
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.logoAnimator.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(50);
            animation6.RotateCoeff = 1F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.logoAnimator.DefaultAnimation = animation6;
            // 
            // sideBarAnimator
            // 
            this.sideBarAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.sideBarAnimator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.sideBarAnimator.DefaultAnimation = animation5;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1017, 687);
            this.Controls.Add(this.pnlLogInContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.sideBarAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principale";
            this.Text = "TCP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogInContent.ResumeLayout(false);
            this.pnlLogInContent.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunImgBtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxLogo)).EndInit();
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
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Timer tmrScreenShot;
        private System.Windows.Forms.Timer tmrWebCam;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlLogInContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlControlBox;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnClose;
        private System.Windows.Forms.PictureBox pcBxLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton bunImgBtnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton bnFltBtn3;
        private Bunifu.Framework.UI.BunifuFlatButton bnFltBtn2;
        private Bunifu.Framework.UI.BunifuFlatButton bnFltBtn1;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private BunifuAnimatorNS.BunifuTransition sideBarAnimator;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPayload;
        private Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private Bunifu.Framework.UI.BunifuFlatButton buFltBtnTrovaIp;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbConsoleOutput;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPort;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbIPAddress;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox buMtTxtBxLog;
    }
}

