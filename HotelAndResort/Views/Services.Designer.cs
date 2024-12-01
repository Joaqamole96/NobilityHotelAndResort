namespace HotelAndResort.Views
{
    partial class frmServices
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
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.flpSidePanelNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavRooms = new System.Windows.Forms.Button();
            this.btnNavServices = new System.Windows.Forms.Button();
            this.btnNavAbout = new System.Windows.Forms.Button();
            this.btnNavContact = new System.Windows.Forms.Button();
            this.btnNavLogin = new System.Windows.Forms.Button();
            this.btnNavExit = new System.Windows.Forms.Button();
            this.lblSidePanelCredits = new System.Windows.Forms.Label();
            this.lblSidePanelTitle = new System.Windows.Forms.Label();
            this.pbxSidePanelLogo = new System.Windows.Forms.PictureBox();
            this.itemTabList1 = new HotelAndResort.Models.UserControls.PageSpecific.RoomsPage.ItemTabList();
            this.pnlSidePanel.SuspendLayout();
            this.flpSidePanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.pnlSidePanel.Controls.Add(this.flpSidePanelNav);
            this.pnlSidePanel.Controls.Add(this.lblSidePanelCredits);
            this.pnlSidePanel.Controls.Add(this.lblSidePanelTitle);
            this.pnlSidePanel.Controls.Add(this.pbxSidePanelLogo);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(202, 720);
            this.pnlSidePanel.TabIndex = 2;
            // 
            // flpSidePanelNav
            // 
            this.flpSidePanelNav.Controls.Add(this.btnNavHome);
            this.flpSidePanelNav.Controls.Add(this.btnNavRooms);
            this.flpSidePanelNav.Controls.Add(this.btnNavServices);
            this.flpSidePanelNav.Controls.Add(this.btnNavAbout);
            this.flpSidePanelNav.Controls.Add(this.btnNavContact);
            this.flpSidePanelNav.Controls.Add(this.btnNavLogin);
            this.flpSidePanelNav.Controls.Add(this.btnNavExit);
            this.flpSidePanelNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSidePanelNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidePanelNav.Location = new System.Drawing.Point(0, 270);
            this.flpSidePanelNav.Name = "flpSidePanelNav";
            this.flpSidePanelNav.Size = new System.Drawing.Size(202, 450);
            this.flpSidePanelNav.TabIndex = 18;
            // 
            // btnNavHome
            // 
            this.btnNavHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnNavHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.Location = new System.Drawing.Point(2, 2);
            this.btnNavHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(198, 30);
            this.btnNavHome.TabIndex = 8;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = false;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
            // 
            // btnNavRooms
            // 
            this.btnNavRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnNavRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRooms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavRooms.Location = new System.Drawing.Point(2, 36);
            this.btnNavRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavRooms.Name = "btnNavRooms";
            this.btnNavRooms.Size = new System.Drawing.Size(198, 30);
            this.btnNavRooms.TabIndex = 9;
            this.btnNavRooms.Text = "Rooms";
            this.btnNavRooms.UseVisualStyleBackColor = false;
            this.btnNavRooms.Click += new System.EventHandler(this.btnNavRooms_Click);
            // 
            // btnNavServices
            // 
            this.btnNavServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnNavServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavServices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavServices.Location = new System.Drawing.Point(2, 70);
            this.btnNavServices.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavServices.Name = "btnNavServices";
            this.btnNavServices.Size = new System.Drawing.Size(198, 30);
            this.btnNavServices.TabIndex = 10;
            this.btnNavServices.Text = "Services";
            this.btnNavServices.UseVisualStyleBackColor = false;
            this.btnNavServices.Click += new System.EventHandler(this.btnNavServices_Click);
            // 
            // btnNavAbout
            // 
            this.btnNavAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnNavAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAbout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAbout.Location = new System.Drawing.Point(2, 104);
            this.btnNavAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavAbout.Name = "btnNavAbout";
            this.btnNavAbout.Size = new System.Drawing.Size(198, 30);
            this.btnNavAbout.TabIndex = 11;
            this.btnNavAbout.Text = "About Us";
            this.btnNavAbout.UseVisualStyleBackColor = false;
            this.btnNavAbout.Click += new System.EventHandler(this.btnNavAbout_Click);
            // 
            // btnNavContact
            // 
            this.btnNavContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnNavContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavContact.Location = new System.Drawing.Point(2, 138);
            this.btnNavContact.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavContact.Name = "btnNavContact";
            this.btnNavContact.Size = new System.Drawing.Size(198, 30);
            this.btnNavContact.TabIndex = 12;
            this.btnNavContact.Text = "Contact Us ";
            this.btnNavContact.UseVisualStyleBackColor = false;
            this.btnNavContact.Click += new System.EventHandler(this.btnNavContact_Click);
            // 
            // btnNavLogin
            // 
            this.btnNavLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnNavLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLogin.Location = new System.Drawing.Point(2, 172);
            this.btnNavLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavLogin.Name = "btnNavLogin";
            this.btnNavLogin.Size = new System.Drawing.Size(198, 30);
            this.btnNavLogin.TabIndex = 13;
            this.btnNavLogin.Text = "Login";
            this.btnNavLogin.UseVisualStyleBackColor = false;
            this.btnNavLogin.Click += new System.EventHandler(this.btnNavLogin_Click);
            // 
            // btnNavExit
            // 
            this.btnNavExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnNavExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavExit.Location = new System.Drawing.Point(2, 206);
            this.btnNavExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavExit.Name = "btnNavExit";
            this.btnNavExit.Size = new System.Drawing.Size(198, 30);
            this.btnNavExit.TabIndex = 14;
            this.btnNavExit.Text = "Exit";
            this.btnNavExit.UseVisualStyleBackColor = false;
            this.btnNavExit.Click += new System.EventHandler(this.btnNavExit_Click);
            // 
            // lblSidePanelCredits
            // 
            this.lblSidePanelCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSidePanelCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblSidePanelCredits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidePanelCredits.Location = new System.Drawing.Point(1, 189);
            this.lblSidePanelCredits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSidePanelCredits.Name = "lblSidePanelCredits";
            this.lblSidePanelCredits.Size = new System.Drawing.Size(200, 18);
            this.lblSidePanelCredits.TabIndex = 17;
            this.lblSidePanelCredits.Text = "by Resortify";
            this.lblSidePanelCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSidePanelTitle
            // 
            this.lblSidePanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSidePanelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSidePanelTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidePanelTitle.Location = new System.Drawing.Point(1, 145);
            this.lblSidePanelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSidePanelTitle.Name = "lblSidePanelTitle";
            this.lblSidePanelTitle.Size = new System.Drawing.Size(200, 44);
            this.lblSidePanelTitle.TabIndex = 16;
            this.lblSidePanelTitle.Text = "Nobility Hotel \r\nand Resort";
            this.lblSidePanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSidePanelLogo
            // 
            this.pbxSidePanelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSidePanelLogo.Location = new System.Drawing.Point(30, 15);
            this.pbxSidePanelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSidePanelLogo.Name = "pbxSidePanelLogo";
            this.pbxSidePanelLogo.Size = new System.Drawing.Size(142, 100);
            this.pbxSidePanelLogo.TabIndex = 15;
            this.pbxSidePanelLogo.TabStop = false;
            // 
            // itemTabList1
            // 
            this.itemTabList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemTabList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemTabList1.Location = new System.Drawing.Point(202, 0);
            this.itemTabList1.Name = "itemTabList1";
            this.itemTabList1.Size = new System.Drawing.Size(1078, 720);
            this.itemTabList1.TabIndex = 3;
            this.itemTabList1.Load += new System.EventHandler(this.itemTabList1_Load);
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.itemTabList1);
            this.Controls.Add(this.pnlSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services | Nobility Hotel and Resort";
            this.pnlSidePanel.ResumeLayout(false);
            this.flpSidePanelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.FlowLayoutPanel flpSidePanelNav;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavRooms;
        private System.Windows.Forms.Button btnNavServices;
        private System.Windows.Forms.Button btnNavAbout;
        private System.Windows.Forms.Button btnNavContact;
        private System.Windows.Forms.Button btnNavLogin;
        private System.Windows.Forms.Button btnNavExit;
        private System.Windows.Forms.Label lblSidePanelCredits;
        private System.Windows.Forms.Label lblSidePanelTitle;
        private System.Windows.Forms.PictureBox pbxSidePanelLogo;
        private Models.UserControls.PageSpecific.RoomsPage.ItemTabList itemTabList1;
    }
}