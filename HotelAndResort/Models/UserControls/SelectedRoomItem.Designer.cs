namespace HotelAndResort.Models.UserControls
{
    partial class SelectedRoomItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxRoomThumbnail = new System.Windows.Forms.PictureBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomCapacity = new System.Windows.Forms.Label();
            this.lblRoomDescription = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.lblRemoveItem = new System.Windows.Forms.Label();
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.tlpServices = new System.Windows.Forms.TableLayoutPanel();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblLabelServices = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblLabelGuests = new System.Windows.Forms.Label();
            this.tlpDates = new System.Windows.Forms.TableLayoutPanel();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblLabelCheckOut = new System.Windows.Forms.Label();
            this.lblLabelCheckIn = new System.Windows.Forms.Label();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.tlpServices.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxRoomThumbnail
            // 
            this.pbxRoomThumbnail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxRoomThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRoomThumbnail.Location = new System.Drawing.Point(10, 10);
            this.pbxRoomThumbnail.Margin = new System.Windows.Forms.Padding(5);
            this.pbxRoomThumbnail.Name = "pbxRoomThumbnail";
            this.pbxRoomThumbnail.Size = new System.Drawing.Size(103, 100);
            this.pbxRoomThumbnail.TabIndex = 24;
            this.pbxRoomThumbnail.TabStop = false;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(123, 10);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(5);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(209, 22);
            this.lblRoomType.TabIndex = 25;
            this.lblRoomType.Text = "[RoomType]";
            // 
            // lblRoomCapacity
            // 
            this.lblRoomCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomCapacity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCapacity.Location = new System.Drawing.Point(124, 37);
            this.lblRoomCapacity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblRoomCapacity.Name = "lblRoomCapacity";
            this.lblRoomCapacity.Size = new System.Drawing.Size(208, 16);
            this.lblRoomCapacity.TabIndex = 27;
            this.lblRoomCapacity.Text = "Good for [RoomCapacity]-[RoomCapacity + 1] pax";
            // 
            // lblRoomDescription
            // 
            this.lblRoomDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDescription.Location = new System.Drawing.Point(124, 63);
            this.lblRoomDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomDescription.Name = "lblRoomDescription";
            this.lblRoomDescription.Size = new System.Drawing.Size(208, 47);
            this.lblRoomDescription.TabIndex = 28;
            this.lblRoomDescription.Text = "[RoomDescription]";
            this.lblRoomDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoSize = true;
            this.pnlDetails.Controls.Add(this.tlpControls);
            this.pnlDetails.Controls.Add(this.pnlDivider2);
            this.pnlDetails.Controls.Add(this.tlpServices);
            this.pnlDetails.Controls.Add(this.tableLayoutPanel2);
            this.pnlDetails.Controls.Add(this.tlpDates);
            this.pnlDetails.Controls.Add(this.pnlDivider1);
            this.pnlDetails.Location = new System.Drawing.Point(10, 118);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(322, 142);
            this.pnlDetails.TabIndex = 29;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 2;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.Controls.Add(this.lblRemoveItem, 0, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpControls.Location = new System.Drawing.Point(0, 117);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.Padding = new System.Windows.Forms.Padding(5);
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.Size = new System.Drawing.Size(322, 25);
            this.tlpControls.TabIndex = 38;
            // 
            // lblRemoveItem
            // 
            this.lblRemoveItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveItem.Location = new System.Drawing.Point(5, 5);
            this.lblRemoveItem.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemoveItem.Name = "lblRemoveItem";
            this.lblRemoveItem.Size = new System.Drawing.Size(156, 15);
            this.lblRemoveItem.TabIndex = 29;
            this.lblRemoveItem.Text = "Remove item";
            this.lblRemoveItem.Click += new System.EventHandler(this.lblRemoveItem_Click);
            // 
            // pnlDivider2
            // 
            this.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlDivider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider2.Location = new System.Drawing.Point(0, 112);
            this.pnlDivider2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(322, 5);
            this.pnlDivider2.TabIndex = 37;
            // 
            // tlpServices
            // 
            this.tlpServices.AutoSize = true;
            this.tlpServices.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpServices.ColumnCount = 2;
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpServices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServices.Controls.Add(this.lblServices, 1, 0);
            this.tlpServices.Controls.Add(this.lblLabelServices, 0, 0);
            this.tlpServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpServices.Location = new System.Drawing.Point(0, 85);
            this.tlpServices.Margin = new System.Windows.Forms.Padding(0);
            this.tlpServices.Name = "tlpServices";
            this.tlpServices.RowCount = 1;
            this.tlpServices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpServices.Size = new System.Drawing.Size(322, 27);
            this.tlpServices.TabIndex = 36;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServices.Location = new System.Drawing.Point(75, 7);
            this.lblServices.Margin = new System.Windows.Forms.Padding(5);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(240, 13);
            this.lblServices.TabIndex = 32;
            this.lblServices.Text = "[Services[]]";
            // 
            // lblLabelServices
            // 
            this.lblLabelServices.AutoSize = true;
            this.lblLabelServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelServices.Location = new System.Drawing.Point(7, 7);
            this.lblLabelServices.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabelServices.Name = "lblLabelServices";
            this.lblLabelServices.Size = new System.Drawing.Size(56, 13);
            this.lblLabelServices.TabIndex = 29;
            this.lblLabelServices.Text = "Services";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblGuests, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLabelGuests, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(322, 27);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuests.Location = new System.Drawing.Point(65, 7);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(5);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(250, 13);
            this.lblGuests.TabIndex = 32;
            this.lblGuests.Text = "[Guests[]]";
            // 
            // lblLabelGuests
            // 
            this.lblLabelGuests.AutoSize = true;
            this.lblLabelGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelGuests.Location = new System.Drawing.Point(7, 7);
            this.lblLabelGuests.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabelGuests.Name = "lblLabelGuests";
            this.lblLabelGuests.Size = new System.Drawing.Size(46, 13);
            this.lblLabelGuests.TabIndex = 29;
            this.lblLabelGuests.Text = "Guests";
            // 
            // tlpDates
            // 
            this.tlpDates.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpDates.ColumnCount = 2;
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDates.Controls.Add(this.lblCheckOut, 1, 1);
            this.tlpDates.Controls.Add(this.lblCheckIn, 1, 0);
            this.tlpDates.Controls.Add(this.lblLabelCheckOut, 0, 1);
            this.tlpDates.Controls.Add(this.lblLabelCheckIn, 0, 0);
            this.tlpDates.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDates.Location = new System.Drawing.Point(0, 5);
            this.tlpDates.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDates.Name = "tlpDates";
            this.tlpDates.RowCount = 2;
            this.tlpDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDates.Size = new System.Drawing.Size(322, 53);
            this.tlpDates.TabIndex = 32;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckOut.Location = new System.Drawing.Point(103, 32);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(5);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(212, 14);
            this.lblCheckOut.TabIndex = 33;
            this.lblCheckOut.Text = "[CheckOutDate]";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckIn.Location = new System.Drawing.Point(103, 7);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(212, 13);
            this.lblCheckIn.TabIndex = 32;
            this.lblCheckIn.Text = "[CheckInDate]";
            // 
            // lblLabelCheckOut
            // 
            this.lblLabelCheckOut.AutoSize = true;
            this.lblLabelCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelCheckOut.Location = new System.Drawing.Point(7, 32);
            this.lblLabelCheckOut.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabelCheckOut.Name = "lblLabelCheckOut";
            this.lblLabelCheckOut.Size = new System.Drawing.Size(84, 14);
            this.lblLabelCheckOut.TabIndex = 31;
            this.lblLabelCheckOut.Text = "Check-out Date";
            // 
            // lblLabelCheckIn
            // 
            this.lblLabelCheckIn.AutoSize = true;
            this.lblLabelCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelCheckIn.Location = new System.Drawing.Point(7, 7);
            this.lblLabelCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabelCheckIn.Name = "lblLabelCheckIn";
            this.lblLabelCheckIn.Size = new System.Drawing.Size(84, 13);
            this.lblLabelCheckIn.TabIndex = 29;
            this.lblLabelCheckIn.Text = "Check-in Date";
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider1.Location = new System.Drawing.Point(0, 0);
            this.pnlDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDivider1.MinimumSize = new System.Drawing.Size(0, 5);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(322, 5);
            this.pnlDivider1.TabIndex = 29;
            // 
            // SelectedRoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.lblRoomDescription);
            this.Controls.Add(this.lblRoomCapacity);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.pbxRoomThumbnail);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(340, 0);
            this.Name = "SelectedRoomItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(340, 268);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.tlpControls.ResumeLayout(false);
            this.tlpServices.ResumeLayout(false);
            this.tlpServices.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpDates.ResumeLayout(false);
            this.tlpDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRoomThumbnail;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomCapacity;
        private System.Windows.Forms.Label lblRoomDescription;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.TableLayoutPanel tlpDates;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblLabelCheckOut;
        private System.Windows.Forms.Label lblLabelCheckIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblLabelGuests;
        private System.Windows.Forms.TableLayoutPanel tlpServices;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblLabelServices;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.Label lblRemoveItem;
    }
}
