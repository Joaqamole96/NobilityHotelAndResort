namespace HotelAndResort.Views
{
    partial class frmBookingRooms
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
            this.pnlBookingDetails = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlGuests = new System.Windows.Forms.Panel();
            this.tbxTotalCount = new System.Windows.Forms.TextBox();
            this.tbxLabelSpecialCount = new System.Windows.Forms.TextBox();
            this.nudSpecialCount = new System.Windows.Forms.NumericUpDown();
            this.tbxLabelChildrenCount = new System.Windows.Forms.TextBox();
            this.nudChildrenCount = new System.Windows.Forms.NumericUpDown();
            this.tbxLabelAdultCount = new System.Windows.Forms.TextBox();
            this.nudAdultCount = new System.Windows.Forms.NumericUpDown();
            this.tbxLabelTotalCount = new System.Windows.Forms.TextBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.pnlDates = new System.Windows.Forms.Panel();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblDates = new System.Windows.Forms.Label();
            this.flpAvailableRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSelectedRoom = new System.Windows.Forms.Panel();
            this.pnlSidePanel.SuspendLayout();
            this.flpSidePanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).BeginInit();
            this.pnlBookingDetails.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultCount)).BeginInit();
            this.pnlDates.SuspendLayout();
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
            this.pnlSidePanel.TabIndex = 1;
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
            this.lblSidePanelTitle.Location = new System.Drawing.Point(0, 145);
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
            // pnlBookingDetails
            // 
            this.pnlBookingDetails.Controls.Add(this.lblBookingDetails);
            this.pnlBookingDetails.Controls.Add(this.pnlSearch);
            this.pnlBookingDetails.Controls.Add(this.pnlGuests);
            this.pnlBookingDetails.Controls.Add(this.pnlDates);
            this.pnlBookingDetails.Location = new System.Drawing.Point(200, 0);
            this.pnlBookingDetails.Name = "pnlBookingDetails";
            this.pnlBookingDetails.Size = new System.Drawing.Size(1080, 150);
            this.pnlBookingDetails.TabIndex = 2;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new System.Drawing.Point(864, 30);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(214, 118);
            this.pnlSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(26, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search for Rooms";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pnlGuests
            // 
            this.pnlGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGuests.Controls.Add(this.tbxTotalCount);
            this.pnlGuests.Controls.Add(this.tbxLabelSpecialCount);
            this.pnlGuests.Controls.Add(this.nudSpecialCount);
            this.pnlGuests.Controls.Add(this.tbxLabelChildrenCount);
            this.pnlGuests.Controls.Add(this.nudChildrenCount);
            this.pnlGuests.Controls.Add(this.tbxLabelAdultCount);
            this.pnlGuests.Controls.Add(this.nudAdultCount);
            this.pnlGuests.Controls.Add(this.tbxLabelTotalCount);
            this.pnlGuests.Controls.Add(this.lblGuests);
            this.pnlGuests.Location = new System.Drawing.Point(540, 30);
            this.pnlGuests.Name = "pnlGuests";
            this.pnlGuests.Size = new System.Drawing.Size(324, 118);
            this.pnlGuests.TabIndex = 3;
            // 
            // tbxTotalCount
            // 
            this.tbxTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalCount.Location = new System.Drawing.Point(103, 34);
            this.tbxTotalCount.Name = "tbxTotalCount";
            this.tbxTotalCount.ReadOnly = true;
            this.tbxTotalCount.Size = new System.Drawing.Size(56, 22);
            this.tbxTotalCount.TabIndex = 11;
            this.tbxTotalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxLabelSpecialCount
            // 
            this.tbxLabelSpecialCount.Location = new System.Drawing.Point(176, 86);
            this.tbxLabelSpecialCount.Name = "tbxLabelSpecialCount";
            this.tbxLabelSpecialCount.ReadOnly = true;
            this.tbxLabelSpecialCount.Size = new System.Drawing.Size(74, 20);
            this.tbxLabelSpecialCount.TabIndex = 10;
            this.tbxLabelSpecialCount.Text = "Senior/PWD:";
            // 
            // nudSpecialCount
            // 
            this.nudSpecialCount.Location = new System.Drawing.Point(250, 86);
            this.nudSpecialCount.Name = "nudSpecialCount";
            this.nudSpecialCount.Size = new System.Drawing.Size(44, 20);
            this.nudSpecialCount.TabIndex = 9;
            // 
            // tbxLabelChildrenCount
            // 
            this.tbxLabelChildrenCount.Location = new System.Drawing.Point(176, 60);
            this.tbxLabelChildrenCount.Name = "tbxLabelChildrenCount";
            this.tbxLabelChildrenCount.ReadOnly = true;
            this.tbxLabelChildrenCount.Size = new System.Drawing.Size(74, 20);
            this.tbxLabelChildrenCount.TabIndex = 8;
            this.tbxLabelChildrenCount.Text = "Children:";
            // 
            // nudChildrenCount
            // 
            this.nudChildrenCount.Location = new System.Drawing.Point(250, 60);
            this.nudChildrenCount.Name = "nudChildrenCount";
            this.nudChildrenCount.Size = new System.Drawing.Size(44, 20);
            this.nudChildrenCount.TabIndex = 7;
            // 
            // tbxLabelAdultCount
            // 
            this.tbxLabelAdultCount.Location = new System.Drawing.Point(176, 34);
            this.tbxLabelAdultCount.Name = "tbxLabelAdultCount";
            this.tbxLabelAdultCount.ReadOnly = true;
            this.tbxLabelAdultCount.Size = new System.Drawing.Size(74, 20);
            this.tbxLabelAdultCount.TabIndex = 6;
            this.tbxLabelAdultCount.Text = "Adults:";
            // 
            // nudAdultCount
            // 
            this.nudAdultCount.Location = new System.Drawing.Point(250, 34);
            this.nudAdultCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultCount.Name = "nudAdultCount";
            this.nudAdultCount.Size = new System.Drawing.Size(44, 20);
            this.nudAdultCount.TabIndex = 5;
            this.nudAdultCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxLabelTotalCount
            // 
            this.tbxLabelTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLabelTotalCount.Location = new System.Drawing.Point(13, 34);
            this.tbxLabelTotalCount.Name = "tbxLabelTotalCount";
            this.tbxLabelTotalCount.ReadOnly = true;
            this.tbxLabelTotalCount.Size = new System.Drawing.Size(90, 22);
            this.tbxLabelTotalCount.TabIndex = 4;
            this.tbxLabelTotalCount.Text = "Total Guests:";
            // 
            // lblGuests
            // 
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(2, 2);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(320, 23);
            this.lblGuests.TabIndex = 1;
            this.lblGuests.Text = "Guests";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookingDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDetails.Location = new System.Drawing.Point(0, 0);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(1080, 30);
            this.lblBookingDetails.TabIndex = 0;
            this.lblBookingDetails.Text = "Main Details";
            this.lblBookingDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDates
            // 
            this.pnlDates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDates.Controls.Add(this.lblCheckOut);
            this.pnlDates.Controls.Add(this.dtpCheckOut);
            this.pnlDates.Controls.Add(this.lblCheckIn);
            this.pnlDates.Controls.Add(this.dtpCheckIn);
            this.pnlDates.Controls.Add(this.lblDates);
            this.pnlDates.Location = new System.Drawing.Point(0, 30);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(540, 118);
            this.pnlDates.TabIndex = 2;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(293, 27);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(56, 13);
            this.lblCheckOut.TabIndex = 6;
            this.lblCheckOut.Text = "Check-out";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(296, 43);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 5;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(42, 27);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(49, 13);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "Check-in";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(40, 43);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 3;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // lblDates
            // 
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(2, 2);
            this.lblDates.Margin = new System.Windows.Forms.Padding(0);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(536, 23);
            this.lblDates.TabIndex = 1;
            this.lblDates.Text = "Dates";
            this.lblDates.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpAvailableRooms
            // 
            this.flpAvailableRooms.Location = new System.Drawing.Point(227, 175);
            this.flpAvailableRooms.Name = "flpAvailableRooms";
            this.flpAvailableRooms.Size = new System.Drawing.Size(712, 520);
            this.flpAvailableRooms.TabIndex = 3;
            // 
            // pnlSelectedRoom
            // 
            this.pnlSelectedRoom.Location = new System.Drawing.Point(964, 150);
            this.pnlSelectedRoom.Name = "pnlSelectedRoom";
            this.pnlSelectedRoom.Size = new System.Drawing.Size(316, 570);
            this.pnlSelectedRoom.TabIndex = 4;
            // 
            // frmBookingRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlSelectedRoom);
            this.Controls.Add(this.flpAvailableRooms);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.pnlBookingDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingRooms";
            this.Load += new System.EventHandler(this.BookingRooms_Load);
            this.pnlSidePanel.ResumeLayout(false);
            this.flpSidePanelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).EndInit();
            this.pnlBookingDetails.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlGuests.ResumeLayout(false);
            this.pnlGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultCount)).EndInit();
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
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
        private System.Windows.Forms.Panel pnlBookingDetails;
        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Panel pnlDates;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlGuests;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxLabelTotalCount;
        private System.Windows.Forms.TextBox tbxLabelAdultCount;
        private System.Windows.Forms.NumericUpDown nudAdultCount;
        private System.Windows.Forms.TextBox tbxLabelSpecialCount;
        private System.Windows.Forms.NumericUpDown nudSpecialCount;
        private System.Windows.Forms.TextBox tbxLabelChildrenCount;
        private System.Windows.Forms.NumericUpDown nudChildrenCount;
        private System.Windows.Forms.TextBox tbxTotalCount;
        private System.Windows.Forms.FlowLayoutPanel flpAvailableRooms;
        private System.Windows.Forms.Panel pnlSelectedRoom;
    }
}