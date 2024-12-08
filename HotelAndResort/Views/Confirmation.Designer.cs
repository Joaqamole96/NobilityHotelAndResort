namespace HotelAndResort.Views
{
    partial class Confirmation
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlConfirmationControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlConfirmation = new System.Windows.Forms.Panel();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.pnlReservationDetails = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpDates = new System.Windows.Forms.TableLayoutPanel();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblLabelCheckOut = new System.Windows.Forms.Label();
            this.lblLabelCheckIn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.lblLabelTotalPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReservationPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlReservation = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flpReservedRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReservedRooms = new System.Windows.Forms.Label();
            this.flpReservedAmenities = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReservedAmenities = new System.Windows.Forms.Label();
            this.pnlConfirmationControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlConfirmation.SuspendLayout();
            this.pnlReservationDetails.SuspendLayout();
            this.tlpDates.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlReservation.SuspendLayout();
            this.flpReservedRooms.SuspendLayout();
            this.flpReservedAmenities.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Brown;
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTopBar.Size = new System.Drawing.Size(512, 30);
            this.pnlTopBar.TabIndex = 8;
            // 
            // pnlConfirmationControls
            // 
            this.pnlConfirmationControls.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlConfirmationControls.Controls.Add(this.tableLayoutPanel1);
            this.pnlConfirmationControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConfirmationControls.Location = new System.Drawing.Point(0, 382);
            this.pnlConfirmationControls.Name = "pnlConfirmationControls";
            this.pnlConfirmationControls.Size = new System.Drawing.Size(512, 50);
            this.pnlConfirmationControls.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(259, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(13, 8);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(240, 34);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlConfirmation
            // 
            this.pnlConfirmation.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlConfirmation.Controls.Add(this.lblConfirmation);
            this.pnlConfirmation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfirmation.Location = new System.Drawing.Point(0, 30);
            this.pnlConfirmation.Name = "pnlConfirmation";
            this.pnlConfirmation.Size = new System.Drawing.Size(512, 50);
            this.pnlConfirmation.TabIndex = 10;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.Location = new System.Drawing.Point(0, 0);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(512, 50);
            this.lblConfirmation.TabIndex = 0;
            this.lblConfirmation.Text = "Confirm Reservation Details:";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReservationDetails
            // 
            this.pnlReservationDetails.AutoScroll = true;
            this.pnlReservationDetails.Controls.Add(this.flpReservedAmenities);
            this.pnlReservationDetails.Controls.Add(this.flpReservedRooms);
            this.pnlReservationDetails.Controls.Add(this.panel4);
            this.pnlReservationDetails.Controls.Add(this.panel3);
            this.pnlReservationDetails.Controls.Add(this.pnlReservation);
            this.pnlReservationDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservationDetails.Location = new System.Drawing.Point(0, 80);
            this.pnlReservationDetails.Name = "pnlReservationDetails";
            this.pnlReservationDetails.Padding = new System.Windows.Forms.Padding(10);
            this.pnlReservationDetails.Size = new System.Drawing.Size(512, 302);
            this.pnlReservationDetails.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 5);
            this.panel2.TabIndex = 42;
            // 
            // tlpDates
            // 
            this.tlpDates.AutoSize = true;
            this.tlpDates.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDates.ColumnCount = 2;
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDates.Controls.Add(this.lblCheckOut, 1, 1);
            this.tlpDates.Controls.Add(this.lblCheckIn, 1, 0);
            this.tlpDates.Controls.Add(this.lblLabelCheckOut, 0, 1);
            this.tlpDates.Controls.Add(this.lblLabelCheckIn, 0, 0);
            this.tlpDates.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDates.Location = new System.Drawing.Point(0, 39);
            this.tlpDates.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDates.Name = "tlpDates";
            this.tlpDates.RowCount = 2;
            this.tlpDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDates.Size = new System.Drawing.Size(492, 57);
            this.tlpDates.TabIndex = 40;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(119, 34);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(5);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(367, 17);
            this.lblCheckOut.TabIndex = 33;
            this.lblCheckOut.Text = "[CheckOutDate]";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(119, 6);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(367, 17);
            this.lblCheckIn.TabIndex = 32;
            this.lblCheckIn.Text = "[CheckInDate]";
            // 
            // lblLabelCheckOut
            // 
            this.lblLabelCheckOut.AutoSize = true;
            this.lblLabelCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelCheckOut.Location = new System.Drawing.Point(6, 34);
            this.lblLabelCheckOut.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabelCheckOut.Name = "lblLabelCheckOut";
            this.lblLabelCheckOut.Size = new System.Drawing.Size(102, 17);
            this.lblLabelCheckOut.TabIndex = 31;
            this.lblLabelCheckOut.Text = "Check-out Date";
            // 
            // lblLabelCheckIn
            // 
            this.lblLabelCheckIn.AutoSize = true;
            this.lblLabelCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelCheckIn.Location = new System.Drawing.Point(6, 6);
            this.lblLabelCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabelCheckIn.Name = "lblLabelCheckIn";
            this.lblLabelCheckIn.Size = new System.Drawing.Size(102, 17);
            this.lblLabelCheckIn.TabIndex = 29;
            this.lblLabelCheckIn.Text = "Check-in Date";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 0);
            this.panel3.TabIndex = 36;
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.Tomato;
            this.pnlDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider1.Location = new System.Drawing.Point(0, 34);
            this.pnlDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDivider1.MinimumSize = new System.Drawing.Size(0, 5);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(492, 5);
            this.pnlDivider1.TabIndex = 39;
            // 
            // lblLabelTotalPrice
            // 
            this.lblLabelTotalPrice.AutoSize = true;
            this.lblLabelTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelTotalPrice.Location = new System.Drawing.Point(6, 6);
            this.lblLabelTotalPrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabelTotalPrice.Name = "lblLabelTotalPrice";
            this.lblLabelTotalPrice.Size = new System.Drawing.Size(73, 17);
            this.lblLabelTotalPrice.TabIndex = 29;
            this.lblLabelTotalPrice.Text = "Total Price";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblReservationPrice, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLabelTotalPrice, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 29);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // lblReservationPrice
            // 
            this.lblReservationPrice.AutoSize = true;
            this.lblReservationPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReservationPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationPrice.Location = new System.Drawing.Point(90, 6);
            this.lblReservationPrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblReservationPrice.Name = "lblReservationPrice";
            this.lblReservationPrice.Size = new System.Drawing.Size(396, 17);
            this.lblReservationPrice.TabIndex = 32;
            this.lblReservationPrice.Text = "[ReservationPrice]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 5);
            this.panel1.TabIndex = 37;
            // 
            // pnlReservation
            // 
            this.pnlReservation.AutoSize = true;
            this.pnlReservation.Controls.Add(this.panel2);
            this.pnlReservation.Controls.Add(this.tlpDates);
            this.pnlReservation.Controls.Add(this.pnlDivider1);
            this.pnlReservation.Controls.Add(this.tableLayoutPanel2);
            this.pnlReservation.Controls.Add(this.panel1);
            this.pnlReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReservation.Location = new System.Drawing.Point(10, 10);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.Size = new System.Drawing.Size(492, 101);
            this.pnlReservation.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 0);
            this.panel4.TabIndex = 37;
            // 
            // flpReservedRooms
            // 
            this.flpReservedRooms.AutoSize = true;
            this.flpReservedRooms.Controls.Add(this.lblReservedRooms);
            this.flpReservedRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpReservedRooms.Location = new System.Drawing.Point(10, 111);
            this.flpReservedRooms.MinimumSize = new System.Drawing.Size(0, 10);
            this.flpReservedRooms.Name = "flpReservedRooms";
            this.flpReservedRooms.Padding = new System.Windows.Forms.Padding(5);
            this.flpReservedRooms.Size = new System.Drawing.Size(492, 27);
            this.flpReservedRooms.TabIndex = 38;
            // 
            // lblReservedRooms
            // 
            this.lblReservedRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservedRooms.Location = new System.Drawing.Point(5, 5);
            this.lblReservedRooms.Margin = new System.Windows.Forms.Padding(0);
            this.lblReservedRooms.Name = "lblReservedRooms";
            this.lblReservedRooms.Size = new System.Drawing.Size(481, 17);
            this.lblReservedRooms.TabIndex = 1;
            this.lblReservedRooms.Text = "Reserved Rooms";
            // 
            // flpReservedAmenities
            // 
            this.flpReservedAmenities.AutoSize = true;
            this.flpReservedAmenities.Controls.Add(this.lblReservedAmenities);
            this.flpReservedAmenities.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpReservedAmenities.Location = new System.Drawing.Point(10, 138);
            this.flpReservedAmenities.MinimumSize = new System.Drawing.Size(0, 10);
            this.flpReservedAmenities.Name = "flpReservedAmenities";
            this.flpReservedAmenities.Padding = new System.Windows.Forms.Padding(5);
            this.flpReservedAmenities.Size = new System.Drawing.Size(492, 27);
            this.flpReservedAmenities.TabIndex = 39;
            // 
            // lblReservedAmenities
            // 
            this.lblReservedAmenities.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservedAmenities.Location = new System.Drawing.Point(5, 5);
            this.lblReservedAmenities.Margin = new System.Windows.Forms.Padding(0);
            this.lblReservedAmenities.Name = "lblReservedAmenities";
            this.lblReservedAmenities.Size = new System.Drawing.Size(481, 17);
            this.lblReservedAmenities.TabIndex = 1;
            this.lblReservedAmenities.Text = "Reserved Amenities";
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(512, 432);
            this.Controls.Add(this.pnlReservationDetails);
            this.Controls.Add(this.pnlConfirmation);
            this.Controls.Add(this.pnlConfirmationControls);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.pnlConfirmationControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlConfirmation.ResumeLayout(false);
            this.pnlReservationDetails.ResumeLayout(false);
            this.pnlReservationDetails.PerformLayout();
            this.tlpDates.ResumeLayout(false);
            this.tlpDates.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlReservation.ResumeLayout(false);
            this.pnlReservation.PerformLayout();
            this.flpReservedRooms.ResumeLayout(false);
            this.flpReservedAmenities.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlConfirmationControls;
        private System.Windows.Forms.Panel pnlConfirmation;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Panel pnlReservationDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlReservation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlpDates;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblLabelCheckOut;
        private System.Windows.Forms.Label lblLabelCheckIn;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblReservationPrice;
        private System.Windows.Forms.Label lblLabelTotalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpReservedAmenities;
        private System.Windows.Forms.Label lblReservedAmenities;
        private System.Windows.Forms.FlowLayoutPanel flpReservedRooms;
        private System.Windows.Forms.Label lblReservedRooms;
        private System.Windows.Forms.Panel panel4;
    }
}