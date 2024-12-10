namespace HotelAndResort.Models.UserControls
{
    partial class AdminReservedRoomItem
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
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.pbxRoomThumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(132, 70);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(101, 19);
            this.lblRoomPrice.TabIndex = 29;
            this.lblRoomPrice.Text = "₱ [RoomPrice]";
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuestCount
            // 
            this.lblGuestCount.AutoSize = true;
            this.lblGuestCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestCount.Location = new System.Drawing.Point(133, 32);
            this.lblGuestCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblGuestCount.Name = "lblGuestCount";
            this.lblGuestCount.Size = new System.Drawing.Size(193, 14);
            this.lblGuestCount.TabIndex = 28;
            this.lblGuestCount.Text = "Reserved for [GuestCount] guest/s";
            this.lblGuestCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(132, 9);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(159, 19);
            this.lblRoomNumber.TabIndex = 27;
            this.lblRoomNumber.Text = "Room [RoomNumber]";
            this.lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxRoomThumbnail
            // 
            this.pbxRoomThumbnail.Location = new System.Drawing.Point(9, 9);
            this.pbxRoomThumbnail.Name = "pbxRoomThumbnail";
            this.pbxRoomThumbnail.Size = new System.Drawing.Size(120, 80);
            this.pbxRoomThumbnail.TabIndex = 26;
            this.pbxRoomThumbnail.TabStop = false;
            // 
            // AdminReservedRoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblGuestCount);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.pbxRoomThumbnail);
            this.Name = "AdminReservedRoomItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(280, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblGuestCount;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.PictureBox pbxRoomThumbnail;
    }
}
