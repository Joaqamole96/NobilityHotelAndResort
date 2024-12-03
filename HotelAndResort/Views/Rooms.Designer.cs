namespace HotelAndResort
{
    partial class frmRooms
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
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpItemsList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRoom_Standard = new System.Windows.Forms.Panel();
            this.btnCTABooking_Standard = new System.Windows.Forms.Button();
            this.lblRoomDescription_Standard = new System.Windows.Forms.Label();
            this.lblRoomDisclaimer_Standard = new System.Windows.Forms.Label();
            this.lblRoomCapacity_Standard = new System.Windows.Forms.Label();
            this.lblRoomPrice_Standard = new System.Windows.Forms.Label();
            this.pbxRoomThumbnail_Standard = new System.Windows.Forms.PictureBox();
            this.lblRoomType_Standard = new System.Windows.Forms.Label();
            this.pnlRoom_Premium = new System.Windows.Forms.Panel();
            this.btnCTABooking_Premium = new System.Windows.Forms.Button();
            this.lblRoomDescription_Premium = new System.Windows.Forms.Label();
            this.lblRoomDisclaimer_Premium = new System.Windows.Forms.Label();
            this.lblRoomCapacity_Premium = new System.Windows.Forms.Label();
            this.lblRoomPrice_Premium = new System.Windows.Forms.Label();
            this.pbxRoomThumbnail_Premium = new System.Windows.Forms.PictureBox();
            this.lblRoomType_Premium = new System.Windows.Forms.Label();
            this.pnlRooms_Deluxe = new System.Windows.Forms.Panel();
            this.btnCTABooking_Deluxe = new System.Windows.Forms.Button();
            this.lblRoomDescription_Deluxe = new System.Windows.Forms.Label();
            this.lblRoomDisclaimer_Deluxe = new System.Windows.Forms.Label();
            this.lblRoomCapacity_Deluxe = new System.Windows.Forms.Label();
            this.lblRoomPrice_Deluxe = new System.Windows.Forms.Label();
            this.pbxRoomThumbnail_Deluxe = new System.Windows.Forms.PictureBox();
            this.lblRoomType_Deluxe = new System.Windows.Forms.Label();
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
            this.pnlRooms.SuspendLayout();
            this.flpItemsList.SuspendLayout();
            this.pnlRoom_Standard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail_Standard)).BeginInit();
            this.pnlRoom_Premium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail_Premium)).BeginInit();
            this.pnlRooms_Deluxe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail_Deluxe)).BeginInit();
            this.pnlSidePanel.SuspendLayout();
            this.flpSidePanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRooms
            // 
            this.pnlRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRooms.Controls.Add(this.lblTitle);
            this.pnlRooms.Controls.Add(this.flpItemsList);
            this.pnlRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRooms.Location = new System.Drawing.Point(202, 0);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(1078, 720);
            this.pnlRooms.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(44, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 31);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Room Types";
            // 
            // flpItemsList
            // 
            this.flpItemsList.AutoScroll = true;
            this.flpItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpItemsList.Controls.Add(this.pnlRoom_Standard);
            this.flpItemsList.Controls.Add(this.pnlRoom_Premium);
            this.flpItemsList.Controls.Add(this.pnlRooms_Deluxe);
            this.flpItemsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpItemsList.Location = new System.Drawing.Point(44, 90);
            this.flpItemsList.Name = "flpItemsList";
            this.flpItemsList.Size = new System.Drawing.Size(990, 590);
            this.flpItemsList.TabIndex = 13;
            this.flpItemsList.WrapContents = false;
            // 
            // pnlRoom_Standard
            // 
            this.pnlRoom_Standard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoom_Standard.Controls.Add(this.btnCTABooking_Standard);
            this.pnlRoom_Standard.Controls.Add(this.lblRoomDescription_Standard);
            this.pnlRoom_Standard.Controls.Add(this.lblRoomDisclaimer_Standard);
            this.pnlRoom_Standard.Controls.Add(this.lblRoomCapacity_Standard);
            this.pnlRoom_Standard.Controls.Add(this.lblRoomPrice_Standard);
            this.pnlRoom_Standard.Controls.Add(this.pbxRoomThumbnail_Standard);
            this.pnlRoom_Standard.Controls.Add(this.lblRoomType_Standard);
            this.pnlRoom_Standard.Location = new System.Drawing.Point(3, 3);
            this.pnlRoom_Standard.Name = "pnlRoom_Standard";
            this.pnlRoom_Standard.Size = new System.Drawing.Size(982, 121);
            this.pnlRoom_Standard.TabIndex = 0;
            // 
            // btnCTABooking_Standard
            // 
            this.btnCTABooking_Standard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTABooking_Standard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnCTABooking_Standard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTABooking_Standard.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTABooking_Standard.Location = new System.Drawing.Point(820, 87);
            this.btnCTABooking_Standard.Margin = new System.Windows.Forms.Padding(0);
            this.btnCTABooking_Standard.Name = "btnCTABooking_Standard";
            this.btnCTABooking_Standard.Size = new System.Drawing.Size(150, 22);
            this.btnCTABooking_Standard.TabIndex = 20;
            this.btnCTABooking_Standard.Text = "Make a Reservation";
            this.btnCTABooking_Standard.UseVisualStyleBackColor = false;
            this.btnCTABooking_Standard.Click += new System.EventHandler(this.btnCTABooking_Standard_Click);
            // 
            // lblRoomDescription_Standard
            // 
            this.lblRoomDescription_Standard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRoomDescription_Standard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDescription_Standard.Location = new System.Drawing.Point(167, 74);
            this.lblRoomDescription_Standard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomDescription_Standard.Name = "lblRoomDescription_Standard";
            this.lblRoomDescription_Standard.Size = new System.Drawing.Size(597, 30);
            this.lblRoomDescription_Standard.TabIndex = 19;
            this.lblRoomDescription_Standard.Text = "A basic room with essential amenities.";
            this.lblRoomDescription_Standard.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRoomDisclaimer_Standard
            // 
            this.lblRoomDisclaimer_Standard.AutoSize = true;
            this.lblRoomDisclaimer_Standard.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDisclaimer_Standard.Location = new System.Drawing.Point(889, 35);
            this.lblRoomDisclaimer_Standard.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomDisclaimer_Standard.Name = "lblRoomDisclaimer_Standard";
            this.lblRoomDisclaimer_Standard.Size = new System.Drawing.Size(83, 42);
            this.lblRoomDisclaimer_Standard.TabIndex = 17;
            this.lblRoomDisclaimer_Standard.Text = "per night \r\n(Including taxes \r\nand fees)";
            this.lblRoomDisclaimer_Standard.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoomCapacity_Standard
            // 
            this.lblRoomCapacity_Standard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCapacity_Standard.Location = new System.Drawing.Point(170, 38);
            this.lblRoomCapacity_Standard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomCapacity_Standard.Name = "lblRoomCapacity_Standard";
            this.lblRoomCapacity_Standard.Size = new System.Drawing.Size(200, 16);
            this.lblRoomCapacity_Standard.TabIndex = 18;
            this.lblRoomCapacity_Standard.Text = "Good for 2-3 people";
            // 
            // lblRoomPrice_Standard
            // 
            this.lblRoomPrice_Standard.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice_Standard.Location = new System.Drawing.Point(772, 10);
            this.lblRoomPrice_Standard.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomPrice_Standard.Name = "lblRoomPrice_Standard";
            this.lblRoomPrice_Standard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomPrice_Standard.Size = new System.Drawing.Size(200, 25);
            this.lblRoomPrice_Standard.TabIndex = 16;
            this.lblRoomPrice_Standard.Text = "₱ 2,000.00";
            this.lblRoomPrice_Standard.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxRoomThumbnail_Standard
            // 
            this.pbxRoomThumbnail_Standard.Location = new System.Drawing.Point(9, 14);
            this.pbxRoomThumbnail_Standard.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRoomThumbnail_Standard.Name = "pbxRoomThumbnail_Standard";
            this.pbxRoomThumbnail_Standard.Size = new System.Drawing.Size(150, 100);
            this.pbxRoomThumbnail_Standard.TabIndex = 15;
            this.pbxRoomThumbnail_Standard.TabStop = false;
            // 
            // lblRoomType_Standard
            // 
            this.lblRoomType_Standard.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType_Standard.Location = new System.Drawing.Point(170, 16);
            this.lblRoomType_Standard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomType_Standard.Name = "lblRoomType_Standard";
            this.lblRoomType_Standard.Size = new System.Drawing.Size(200, 22);
            this.lblRoomType_Standard.TabIndex = 14;
            this.lblRoomType_Standard.Text = "Standard Room";
            this.lblRoomType_Standard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRoom_Premium
            // 
            this.pnlRoom_Premium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoom_Premium.Controls.Add(this.btnCTABooking_Premium);
            this.pnlRoom_Premium.Controls.Add(this.lblRoomDescription_Premium);
            this.pnlRoom_Premium.Controls.Add(this.lblRoomDisclaimer_Premium);
            this.pnlRoom_Premium.Controls.Add(this.lblRoomCapacity_Premium);
            this.pnlRoom_Premium.Controls.Add(this.lblRoomPrice_Premium);
            this.pnlRoom_Premium.Controls.Add(this.pbxRoomThumbnail_Premium);
            this.pnlRoom_Premium.Controls.Add(this.lblRoomType_Premium);
            this.pnlRoom_Premium.Location = new System.Drawing.Point(3, 130);
            this.pnlRoom_Premium.Name = "pnlRoom_Premium";
            this.pnlRoom_Premium.Size = new System.Drawing.Size(982, 121);
            this.pnlRoom_Premium.TabIndex = 1;
            // 
            // btnCTABooking_Premium
            // 
            this.btnCTABooking_Premium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTABooking_Premium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnCTABooking_Premium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTABooking_Premium.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTABooking_Premium.Location = new System.Drawing.Point(820, 87);
            this.btnCTABooking_Premium.Margin = new System.Windows.Forms.Padding(0);
            this.btnCTABooking_Premium.Name = "btnCTABooking_Premium";
            this.btnCTABooking_Premium.Size = new System.Drawing.Size(150, 22);
            this.btnCTABooking_Premium.TabIndex = 20;
            this.btnCTABooking_Premium.Text = "Make a Reservation";
            this.btnCTABooking_Premium.UseVisualStyleBackColor = false;
            this.btnCTABooking_Premium.Click += new System.EventHandler(this.btnCTABooking_Premium_Click);
            // 
            // lblRoomDescription_Premium
            // 
            this.lblRoomDescription_Premium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRoomDescription_Premium.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDescription_Premium.Location = new System.Drawing.Point(167, 74);
            this.lblRoomDescription_Premium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomDescription_Premium.Name = "lblRoomDescription_Premium";
            this.lblRoomDescription_Premium.Size = new System.Drawing.Size(597, 30);
            this.lblRoomDescription_Premium.TabIndex = 19;
            this.lblRoomDescription_Premium.Text = "A more spacious room with additional features.";
            this.lblRoomDescription_Premium.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRoomDisclaimer_Premium
            // 
            this.lblRoomDisclaimer_Premium.AutoSize = true;
            this.lblRoomDisclaimer_Premium.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDisclaimer_Premium.Location = new System.Drawing.Point(889, 35);
            this.lblRoomDisclaimer_Premium.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomDisclaimer_Premium.Name = "lblRoomDisclaimer_Premium";
            this.lblRoomDisclaimer_Premium.Size = new System.Drawing.Size(83, 42);
            this.lblRoomDisclaimer_Premium.TabIndex = 17;
            this.lblRoomDisclaimer_Premium.Text = "per night \r\n(Including taxes \r\nand fees)";
            this.lblRoomDisclaimer_Premium.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoomCapacity_Premium
            // 
            this.lblRoomCapacity_Premium.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCapacity_Premium.Location = new System.Drawing.Point(170, 38);
            this.lblRoomCapacity_Premium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomCapacity_Premium.Name = "lblRoomCapacity_Premium";
            this.lblRoomCapacity_Premium.Size = new System.Drawing.Size(200, 16);
            this.lblRoomCapacity_Premium.TabIndex = 18;
            this.lblRoomCapacity_Premium.Text = "Good for 3-4 people";
            // 
            // lblRoomPrice_Premium
            // 
            this.lblRoomPrice_Premium.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice_Premium.Location = new System.Drawing.Point(772, 10);
            this.lblRoomPrice_Premium.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomPrice_Premium.Name = "lblRoomPrice_Premium";
            this.lblRoomPrice_Premium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomPrice_Premium.Size = new System.Drawing.Size(200, 25);
            this.lblRoomPrice_Premium.TabIndex = 16;
            this.lblRoomPrice_Premium.Text = "₱ 3,500.00";
            this.lblRoomPrice_Premium.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxRoomThumbnail_Premium
            // 
            this.pbxRoomThumbnail_Premium.Location = new System.Drawing.Point(9, 14);
            this.pbxRoomThumbnail_Premium.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRoomThumbnail_Premium.Name = "pbxRoomThumbnail_Premium";
            this.pbxRoomThumbnail_Premium.Size = new System.Drawing.Size(150, 100);
            this.pbxRoomThumbnail_Premium.TabIndex = 15;
            this.pbxRoomThumbnail_Premium.TabStop = false;
            // 
            // lblRoomType_Premium
            // 
            this.lblRoomType_Premium.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType_Premium.Location = new System.Drawing.Point(170, 16);
            this.lblRoomType_Premium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomType_Premium.Name = "lblRoomType_Premium";
            this.lblRoomType_Premium.Size = new System.Drawing.Size(200, 22);
            this.lblRoomType_Premium.TabIndex = 14;
            this.lblRoomType_Premium.Text = "Premium Room";
            this.lblRoomType_Premium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRooms_Deluxe
            // 
            this.pnlRooms_Deluxe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRooms_Deluxe.Controls.Add(this.btnCTABooking_Deluxe);
            this.pnlRooms_Deluxe.Controls.Add(this.lblRoomDescription_Deluxe);
            this.pnlRooms_Deluxe.Controls.Add(this.lblRoomDisclaimer_Deluxe);
            this.pnlRooms_Deluxe.Controls.Add(this.lblRoomCapacity_Deluxe);
            this.pnlRooms_Deluxe.Controls.Add(this.lblRoomPrice_Deluxe);
            this.pnlRooms_Deluxe.Controls.Add(this.pbxRoomThumbnail_Deluxe);
            this.pnlRooms_Deluxe.Controls.Add(this.lblRoomType_Deluxe);
            this.pnlRooms_Deluxe.Location = new System.Drawing.Point(3, 257);
            this.pnlRooms_Deluxe.Name = "pnlRooms_Deluxe";
            this.pnlRooms_Deluxe.Size = new System.Drawing.Size(982, 121);
            this.pnlRooms_Deluxe.TabIndex = 2;
            // 
            // btnCTABooking_Deluxe
            // 
            this.btnCTABooking_Deluxe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTABooking_Deluxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnCTABooking_Deluxe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTABooking_Deluxe.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTABooking_Deluxe.Location = new System.Drawing.Point(820, 87);
            this.btnCTABooking_Deluxe.Margin = new System.Windows.Forms.Padding(0);
            this.btnCTABooking_Deluxe.Name = "btnCTABooking_Deluxe";
            this.btnCTABooking_Deluxe.Size = new System.Drawing.Size(150, 22);
            this.btnCTABooking_Deluxe.TabIndex = 20;
            this.btnCTABooking_Deluxe.Text = "Make a Reservation";
            this.btnCTABooking_Deluxe.UseVisualStyleBackColor = false;
            this.btnCTABooking_Deluxe.Click += new System.EventHandler(this.btnCTABooking_Deluxe_Click);
            // 
            // lblRoomDescription_Deluxe
            // 
            this.lblRoomDescription_Deluxe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRoomDescription_Deluxe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDescription_Deluxe.Location = new System.Drawing.Point(167, 74);
            this.lblRoomDescription_Deluxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomDescription_Deluxe.Name = "lblRoomDescription_Deluxe";
            this.lblRoomDescription_Deluxe.Size = new System.Drawing.Size(597, 30);
            this.lblRoomDescription_Deluxe.TabIndex = 19;
            this.lblRoomDescription_Deluxe.Text = "A luxurious room with top-notch facilities.";
            this.lblRoomDescription_Deluxe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRoomDisclaimer_Deluxe
            // 
            this.lblRoomDisclaimer_Deluxe.AutoSize = true;
            this.lblRoomDisclaimer_Deluxe.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDisclaimer_Deluxe.Location = new System.Drawing.Point(889, 35);
            this.lblRoomDisclaimer_Deluxe.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomDisclaimer_Deluxe.Name = "lblRoomDisclaimer_Deluxe";
            this.lblRoomDisclaimer_Deluxe.Size = new System.Drawing.Size(83, 42);
            this.lblRoomDisclaimer_Deluxe.TabIndex = 17;
            this.lblRoomDisclaimer_Deluxe.Text = "per night \r\n(Including taxes \r\nand fees)";
            this.lblRoomDisclaimer_Deluxe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoomCapacity_Deluxe
            // 
            this.lblRoomCapacity_Deluxe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCapacity_Deluxe.Location = new System.Drawing.Point(170, 38);
            this.lblRoomCapacity_Deluxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomCapacity_Deluxe.Name = "lblRoomCapacity_Deluxe";
            this.lblRoomCapacity_Deluxe.Size = new System.Drawing.Size(200, 16);
            this.lblRoomCapacity_Deluxe.TabIndex = 18;
            this.lblRoomCapacity_Deluxe.Text = "Good for 4-5 people";
            // 
            // lblRoomPrice_Deluxe
            // 
            this.lblRoomPrice_Deluxe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice_Deluxe.Location = new System.Drawing.Point(772, 10);
            this.lblRoomPrice_Deluxe.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomPrice_Deluxe.Name = "lblRoomPrice_Deluxe";
            this.lblRoomPrice_Deluxe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomPrice_Deluxe.Size = new System.Drawing.Size(200, 25);
            this.lblRoomPrice_Deluxe.TabIndex = 16;
            this.lblRoomPrice_Deluxe.Text = "₱ 5,000.00";
            this.lblRoomPrice_Deluxe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxRoomThumbnail_Deluxe
            // 
            this.pbxRoomThumbnail_Deluxe.Location = new System.Drawing.Point(9, 14);
            this.pbxRoomThumbnail_Deluxe.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRoomThumbnail_Deluxe.Name = "pbxRoomThumbnail_Deluxe";
            this.pbxRoomThumbnail_Deluxe.Size = new System.Drawing.Size(150, 100);
            this.pbxRoomThumbnail_Deluxe.TabIndex = 15;
            this.pbxRoomThumbnail_Deluxe.TabStop = false;
            // 
            // lblRoomType_Deluxe
            // 
            this.lblRoomType_Deluxe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType_Deluxe.Location = new System.Drawing.Point(170, 16);
            this.lblRoomType_Deluxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomType_Deluxe.Name = "lblRoomType_Deluxe";
            this.lblRoomType_Deluxe.Size = new System.Drawing.Size(200, 22);
            this.lblRoomType_Deluxe.TabIndex = 14;
            this.lblRoomType_Deluxe.Text = "Deluxe Room";
            this.lblRoomType_Deluxe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms | Nobility Hotel and Resort";
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            this.flpItemsList.ResumeLayout(false);
            this.pnlRoom_Standard.ResumeLayout(false);
            this.pnlRoom_Standard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail_Standard)).EndInit();
            this.pnlRoom_Premium.ResumeLayout(false);
            this.pnlRoom_Premium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail_Premium)).EndInit();
            this.pnlRooms_Deluxe.ResumeLayout(false);
            this.pnlRooms_Deluxe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail_Deluxe)).EndInit();
            this.pnlSidePanel.ResumeLayout(false);
            this.flpSidePanelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanelLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpItemsList;
        private System.Windows.Forms.Panel pnlRoom_Standard;
        private System.Windows.Forms.Button btnCTABooking_Standard;
        private System.Windows.Forms.Label lblRoomDescription_Standard;
        private System.Windows.Forms.Label lblRoomDisclaimer_Standard;
        private System.Windows.Forms.Label lblRoomCapacity_Standard;
        private System.Windows.Forms.Label lblRoomPrice_Standard;
        private System.Windows.Forms.PictureBox pbxRoomThumbnail_Standard;
        private System.Windows.Forms.Label lblRoomType_Standard;
        private System.Windows.Forms.Panel pnlRoom_Premium;
        private System.Windows.Forms.Button btnCTABooking_Premium;
        private System.Windows.Forms.Label lblRoomDescription_Premium;
        private System.Windows.Forms.Label lblRoomDisclaimer_Premium;
        private System.Windows.Forms.Label lblRoomCapacity_Premium;
        private System.Windows.Forms.Label lblRoomPrice_Premium;
        private System.Windows.Forms.PictureBox pbxRoomThumbnail_Premium;
        private System.Windows.Forms.Label lblRoomType_Premium;
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
        private System.Windows.Forms.Panel pnlRooms_Deluxe;
        private System.Windows.Forms.Button btnCTABooking_Deluxe;
        private System.Windows.Forms.Label lblRoomDescription_Deluxe;
        private System.Windows.Forms.Label lblRoomDisclaimer_Deluxe;
        private System.Windows.Forms.Label lblRoomCapacity_Deluxe;
        private System.Windows.Forms.Label lblRoomPrice_Deluxe;
        private System.Windows.Forms.PictureBox pbxRoomThumbnail_Deluxe;
        private System.Windows.Forms.Label lblRoomType_Deluxe;
    }
}