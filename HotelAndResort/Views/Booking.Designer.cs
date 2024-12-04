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
            this.lblRoomDetails = new System.Windows.Forms.Label();
            this.pnlDates = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.flpBookingDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGuests = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxLabelTotal = new System.Windows.Forms.TextBox();
            this.nudSpecialCount = new System.Windows.Forms.NumericUpDown();
            this.tbxLabelSpecial = new System.Windows.Forms.TextBox();
            this.nudChildrenCount = new System.Windows.Forms.NumericUpDown();
            this.tbxLabelAdult = new System.Windows.Forms.TextBox();
            this.nudAdultCount = new System.Windows.Forms.NumericUpDown();
            this.tbxLabelChildren = new System.Windows.Forms.TextBox();
            this.tbxGuestCount = new System.Windows.Forms.TextBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.tlpSortControls = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSelectedRoom = new System.Windows.Forms.Panel();
            this.flpReservationDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblReservationDetails = new System.Windows.Forms.Label();
            this.tbcBooking = new System.Windows.Forms.TabControl();
            this.tbpgAvailableRooms = new System.Windows.Forms.TabPage();
            this.flpAvailableRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.tbpgAvailableServices = new System.Windows.Forms.TabPage();
            this.pnlSidePanel.SuspendLayout();
            this.flpSidePanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).BeginInit();
            this.pnlDates.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpBookingDetails.SuspendLayout();
            this.pnlGuests.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultCount)).BeginInit();
            this.pnlSelectedRoom.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tbcBooking.SuspendLayout();
            this.tbpgAvailableRooms.SuspendLayout();
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
            this.pnlSidePanel.Margin = new System.Windows.Forms.Padding(5);
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
            this.pbxSidePanelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSidePanelLogo.Location = new System.Drawing.Point(30, 15);
            this.pbxSidePanelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSidePanelLogo.Name = "pbxSidePanelLogo";
            this.pbxSidePanelLogo.Size = new System.Drawing.Size(142, 100);
            this.pbxSidePanelLogo.TabIndex = 15;
            this.pbxSidePanelLogo.TabStop = false;
            // 
            // lblRoomDetails
            // 
            this.lblRoomDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoomDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetails.Location = new System.Drawing.Point(5, 5);
            this.lblRoomDetails.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblRoomDetails.Name = "lblRoomDetails";
            this.lblRoomDetails.Size = new System.Drawing.Size(694, 30);
            this.lblRoomDetails.TabIndex = 0;
            this.lblRoomDetails.Text = "Room Details";
            this.lblRoomDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDates
            // 
            this.pnlDates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDates.Controls.Add(this.tableLayoutPanel1);
            this.pnlDates.Controls.Add(this.lblDates);
            this.pnlDates.Location = new System.Drawing.Point(5, 40);
            this.pnlDates.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(350, 103);
            this.pnlDates.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpCheckIn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpCheckOut, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCheckIn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 78);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Check-out";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpCheckIn.Location = new System.Drawing.Point(71, 5);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(272, 20);
            this.dtpCheckIn.TabIndex = 8;
            this.dtpCheckIn.Value = new System.DateTime(2024, 12, 3, 16, 6, 12, 0);
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpCheckOut.Location = new System.Drawing.Point(71, 44);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(5);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(272, 20);
            this.dtpCheckOut.TabIndex = 5;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(5, 5);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(56, 13);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "Check-in";
            this.lblCheckIn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDates
            // 
            this.lblDates.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(0, 0);
            this.lblDates.Margin = new System.Windows.Forms.Padding(0);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(348, 23);
            this.lblDates.TabIndex = 1;
            this.lblDates.Text = "Reservation Dates";
            this.lblDates.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpBookingDetails
            // 
            this.flpBookingDetails.AutoSize = true;
            this.flpBookingDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpBookingDetails.Controls.Add(this.lblRoomDetails);
            this.flpBookingDetails.Controls.Add(this.pnlDates);
            this.flpBookingDetails.Controls.Add(this.pnlGuests);
            this.flpBookingDetails.Controls.Add(this.tlpSortControls);
            this.flpBookingDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpBookingDetails.Location = new System.Drawing.Point(202, 0);
            this.flpBookingDetails.Margin = new System.Windows.Forms.Padding(5);
            this.flpBookingDetails.Name = "flpBookingDetails";
            this.flpBookingDetails.Padding = new System.Windows.Forms.Padding(5);
            this.flpBookingDetails.Size = new System.Drawing.Size(712, 183);
            this.flpBookingDetails.TabIndex = 5;
            // 
            // pnlGuests
            // 
            this.pnlGuests.AutoSize = true;
            this.pnlGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuests.Controls.Add(this.tableLayoutPanel2);
            this.pnlGuests.Controls.Add(this.lblGuests);
            this.pnlGuests.Location = new System.Drawing.Point(360, 40);
            this.pnlGuests.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlGuests.Name = "pnlGuests";
            this.pnlGuests.Size = new System.Drawing.Size(338, 103);
            this.pnlGuests.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tbxLabelTotal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudSpecialCount, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbxLabelSpecial, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.nudChildrenCount, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxLabelAdult, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudAdultCount, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxLabelChildren, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxGuestCount, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 78);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbxLabelTotal
            // 
            this.tbxLabelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLabelTotal.Location = new System.Drawing.Point(3, 3);
            this.tbxLabelTotal.Name = "tbxLabelTotal";
            this.tbxLabelTotal.ReadOnly = true;
            this.tbxLabelTotal.Size = new System.Drawing.Size(78, 20);
            this.tbxLabelTotal.TabIndex = 14;
            this.tbxLabelTotal.Text = "Total Guests:";
            this.tbxLabelTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudSpecialCount
            // 
            this.nudSpecialCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSpecialCount.Location = new System.Drawing.Point(255, 55);
            this.nudSpecialCount.Name = "nudSpecialCount";
            this.nudSpecialCount.Size = new System.Drawing.Size(78, 20);
            this.nudSpecialCount.TabIndex = 9;
            this.nudSpecialCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSpecialCount.ValueChanged += new System.EventHandler(this.nudSpecialCount_ValueChanged);
            // 
            // tbxLabelSpecial
            // 
            this.tbxLabelSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLabelSpecial.Location = new System.Drawing.Point(171, 55);
            this.tbxLabelSpecial.Name = "tbxLabelSpecial";
            this.tbxLabelSpecial.ReadOnly = true;
            this.tbxLabelSpecial.Size = new System.Drawing.Size(78, 20);
            this.tbxLabelSpecial.TabIndex = 10;
            this.tbxLabelSpecial.Text = "Senior/PWD:";
            this.tbxLabelSpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudChildrenCount
            // 
            this.nudChildrenCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudChildrenCount.Location = new System.Drawing.Point(255, 29);
            this.nudChildrenCount.Name = "nudChildrenCount";
            this.nudChildrenCount.Size = new System.Drawing.Size(78, 20);
            this.nudChildrenCount.TabIndex = 7;
            this.nudChildrenCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudChildrenCount.ValueChanged += new System.EventHandler(this.nudChildrenCount_ValueChanged);
            // 
            // tbxLabelAdult
            // 
            this.tbxLabelAdult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLabelAdult.Location = new System.Drawing.Point(171, 3);
            this.tbxLabelAdult.Name = "tbxLabelAdult";
            this.tbxLabelAdult.ReadOnly = true;
            this.tbxLabelAdult.Size = new System.Drawing.Size(78, 20);
            this.tbxLabelAdult.TabIndex = 6;
            this.tbxLabelAdult.Text = "Adults:";
            this.tbxLabelAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudAdultCount
            // 
            this.nudAdultCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAdultCount.Location = new System.Drawing.Point(255, 3);
            this.nudAdultCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultCount.Name = "nudAdultCount";
            this.nudAdultCount.Size = new System.Drawing.Size(78, 20);
            this.nudAdultCount.TabIndex = 5;
            this.nudAdultCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAdultCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultCount.ValueChanged += new System.EventHandler(this.nudAdultCount_ValueChanged);
            // 
            // tbxLabelChildren
            // 
            this.tbxLabelChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLabelChildren.Location = new System.Drawing.Point(171, 29);
            this.tbxLabelChildren.Name = "tbxLabelChildren";
            this.tbxLabelChildren.ReadOnly = true;
            this.tbxLabelChildren.Size = new System.Drawing.Size(78, 20);
            this.tbxLabelChildren.TabIndex = 8;
            this.tbxLabelChildren.Text = "Children:";
            this.tbxLabelChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxGuestCount
            // 
            this.tbxGuestCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxGuestCount.Location = new System.Drawing.Point(87, 3);
            this.tbxGuestCount.Name = "tbxGuestCount";
            this.tbxGuestCount.ReadOnly = true;
            this.tbxGuestCount.Size = new System.Drawing.Size(78, 20);
            this.tbxGuestCount.TabIndex = 15;
            this.tbxGuestCount.Text = "1";
            this.tbxGuestCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGuests
            // 
            this.lblGuests.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(0, 0);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(336, 23);
            this.lblGuests.TabIndex = 1;
            this.lblGuests.Text = "No. of Guests";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlpSortControls
            // 
            this.tlpSortControls.ColumnCount = 2;
            this.tlpSortControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSortControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSortControls.Location = new System.Drawing.Point(8, 151);
            this.tlpSortControls.Name = "tlpSortControls";
            this.tlpSortControls.RowCount = 1;
            this.tlpSortControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSortControls.Size = new System.Drawing.Size(694, 20);
            this.tlpSortControls.TabIndex = 5;
            // 
            // pnlSelectedRoom
            // 
            this.pnlSelectedRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelectedRoom.Controls.Add(this.flpReservationDetails);
            this.pnlSelectedRoom.Controls.Add(this.tableLayoutPanel3);
            this.pnlSelectedRoom.Controls.Add(this.lblReservationDetails);
            this.pnlSelectedRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSelectedRoom.Location = new System.Drawing.Point(914, 0);
            this.pnlSelectedRoom.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSelectedRoom.Name = "pnlSelectedRoom";
            this.pnlSelectedRoom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSelectedRoom.Size = new System.Drawing.Size(366, 720);
            this.pnlSelectedRoom.TabIndex = 4;
            // 
            // flpReservationDetails
            // 
            this.flpReservationDetails.AutoScroll = true;
            this.flpReservationDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpReservationDetails.Location = new System.Drawing.Point(5, 35);
            this.flpReservationDetails.Margin = new System.Windows.Forms.Padding(0);
            this.flpReservationDetails.Name = "flpReservationDetails";
            this.flpReservationDetails.Size = new System.Drawing.Size(352, 644);
            this.flpReservationDetails.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnNextPage, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 679);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(352, 32);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnNextPage
            // 
            this.btnNextPage.AutoSize = true;
            this.btnNextPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(179, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(170, 26);
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblReservationDetails
            // 
            this.lblReservationDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReservationDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReservationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDetails.Location = new System.Drawing.Point(5, 5);
            this.lblReservationDetails.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.lblReservationDetails.Name = "lblReservationDetails";
            this.lblReservationDetails.Size = new System.Drawing.Size(352, 30);
            this.lblReservationDetails.TabIndex = 1;
            this.lblReservationDetails.Text = "Reservation Details";
            this.lblReservationDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbcBooking
            // 
            this.tbcBooking.Controls.Add(this.tbpgAvailableRooms);
            this.tbcBooking.Controls.Add(this.tbpgAvailableServices);
            this.tbcBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcBooking.Location = new System.Drawing.Point(202, 183);
            this.tbcBooking.Name = "tbcBooking";
            this.tbcBooking.SelectedIndex = 0;
            this.tbcBooking.Size = new System.Drawing.Size(712, 537);
            this.tbcBooking.TabIndex = 6;
            // 
            // tbpgAvailableRooms
            // 
            this.tbpgAvailableRooms.Controls.Add(this.flpAvailableRooms);
            this.tbpgAvailableRooms.Location = new System.Drawing.Point(4, 22);
            this.tbpgAvailableRooms.Name = "tbpgAvailableRooms";
            this.tbpgAvailableRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAvailableRooms.Size = new System.Drawing.Size(704, 511);
            this.tbpgAvailableRooms.TabIndex = 0;
            this.tbpgAvailableRooms.Text = "tabPage1";
            this.tbpgAvailableRooms.UseVisualStyleBackColor = true;
            // 
            // flpAvailableRooms
            // 
            this.flpAvailableRooms.AutoScroll = true;
            this.flpAvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpAvailableRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAvailableRooms.Location = new System.Drawing.Point(3, 3);
            this.flpAvailableRooms.Margin = new System.Windows.Forms.Padding(5);
            this.flpAvailableRooms.Name = "flpAvailableRooms";
            this.flpAvailableRooms.Padding = new System.Windows.Forms.Padding(10);
            this.flpAvailableRooms.Size = new System.Drawing.Size(698, 505);
            this.flpAvailableRooms.TabIndex = 7;
            // 
            // tbpgAvailableServices
            // 
            this.tbpgAvailableServices.Location = new System.Drawing.Point(4, 22);
            this.tbpgAvailableServices.Name = "tbpgAvailableServices";
            this.tbpgAvailableServices.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAvailableServices.Size = new System.Drawing.Size(704, 511);
            this.tbpgAvailableServices.TabIndex = 1;
            this.tbpgAvailableServices.Text = "tabPage2";
            this.tbpgAvailableServices.UseVisualStyleBackColor = true;
            // 
            // frmBookingRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tbcBooking);
            this.Controls.Add(this.flpBookingDetails);
            this.Controls.Add(this.pnlSelectedRoom);
            this.Controls.Add(this.pnlSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingRooms";
            this.Load += new System.EventHandler(this.BookingRooms_Load);
            this.pnlSidePanel.ResumeLayout(false);
            this.flpSidePanelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).EndInit();
            this.pnlDates.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpBookingDetails.ResumeLayout(false);
            this.flpBookingDetails.PerformLayout();
            this.pnlGuests.ResumeLayout(false);
            this.pnlGuests.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultCount)).EndInit();
            this.pnlSelectedRoom.ResumeLayout(false);
            this.pnlSelectedRoom.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tbcBooking.ResumeLayout(false);
            this.tbpgAvailableRooms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblRoomDetails;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Panel pnlDates;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.FlowLayoutPanel flpBookingDetails;
        private System.Windows.Forms.Panel pnlGuests;
        private System.Windows.Forms.TextBox tbxLabelSpecial;
        private System.Windows.Forms.NumericUpDown nudSpecialCount;
        private System.Windows.Forms.TextBox tbxLabelChildren;
        private System.Windows.Forms.NumericUpDown nudChildrenCount;
        private System.Windows.Forms.TextBox tbxLabelAdult;
        private System.Windows.Forms.NumericUpDown nudAdultCount;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbxLabelTotal;
        private System.Windows.Forms.TextBox tbxGuestCount;
        private System.Windows.Forms.Panel pnlSelectedRoom;
        private System.Windows.Forms.Label lblReservationDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flpReservationDetails;
        private System.Windows.Forms.TableLayoutPanel tlpSortControls;
        private System.Windows.Forms.TabControl tbcBooking;
        private System.Windows.Forms.TabPage tbpgAvailableRooms;
        private System.Windows.Forms.FlowLayoutPanel flpAvailableRooms;
        private System.Windows.Forms.TabPage tbpgAvailableServices;
    }
}