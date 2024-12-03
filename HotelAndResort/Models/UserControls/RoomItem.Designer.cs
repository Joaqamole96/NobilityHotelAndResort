namespace HotelAndResort.Models.UserControls
{
    partial class RoomItem
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
            this.btnCTABooking = new System.Windows.Forms.Button();
            this.lblRoomDescription = new System.Windows.Forms.Label();
            this.lblRoomDisclaimer = new System.Windows.Forms.Label();
            this.lblRoomCapacity = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.pbxRoomThumbnail = new System.Windows.Forms.PictureBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCTABooking
            // 
            this.btnCTABooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTABooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnCTABooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTABooking.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTABooking.Location = new System.Drawing.Point(869, 85);
            this.btnCTABooking.Margin = new System.Windows.Forms.Padding(0);
            this.btnCTABooking.Name = "btnCTABooking";
            this.btnCTABooking.Size = new System.Drawing.Size(102, 22);
            this.btnCTABooking.TabIndex = 27;
            this.btnCTABooking.Text = "Select Room";
            this.btnCTABooking.UseVisualStyleBackColor = false;
            // 
            // lblRoomDescription
            // 
            this.lblRoomDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRoomDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDescription.Location = new System.Drawing.Point(168, 72);
            this.lblRoomDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomDescription.Name = "lblRoomDescription";
            this.lblRoomDescription.Size = new System.Drawing.Size(597, 30);
            this.lblRoomDescription.TabIndex = 26;
            this.lblRoomDescription.Text = "[RoomDescription]";
            this.lblRoomDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRoomDisclaimer
            // 
            this.lblRoomDisclaimer.AutoSize = true;
            this.lblRoomDisclaimer.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDisclaimer.Location = new System.Drawing.Point(890, 33);
            this.lblRoomDisclaimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomDisclaimer.Name = "lblRoomDisclaimer";
            this.lblRoomDisclaimer.Size = new System.Drawing.Size(83, 42);
            this.lblRoomDisclaimer.TabIndex = 24;
            this.lblRoomDisclaimer.Text = "per night \r\n(Including taxes \r\nand fees)";
            this.lblRoomDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoomCapacity
            // 
            this.lblRoomCapacity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCapacity.Location = new System.Drawing.Point(171, 36);
            this.lblRoomCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomCapacity.Name = "lblRoomCapacity";
            this.lblRoomCapacity.Size = new System.Drawing.Size(317, 16);
            this.lblRoomCapacity.TabIndex = 25;
            this.lblRoomCapacity.Text = "Good for [RoomCapacity]-[RoomCapacity + 1] people";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(773, 8);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomPrice.Size = new System.Drawing.Size(200, 25);
            this.lblRoomPrice.TabIndex = 23;
            this.lblRoomPrice.Text = "₱ [RoomPrice]";
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxRoomThumbnail
            // 
            this.pbxRoomThumbnail.Location = new System.Drawing.Point(10, 12);
            this.pbxRoomThumbnail.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRoomThumbnail.Name = "pbxRoomThumbnail";
            this.pbxRoomThumbnail.Size = new System.Drawing.Size(150, 100);
            this.pbxRoomThumbnail.TabIndex = 22;
            this.pbxRoomThumbnail.TabStop = false;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(171, 14);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(200, 22);
            this.lblRoomType.TabIndex = 21;
            this.lblRoomType.Text = "[RoomType]";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCTABooking);
            this.Controls.Add(this.lblRoomDescription);
            this.Controls.Add(this.lblRoomDisclaimer);
            this.Controls.Add(this.lblRoomCapacity);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.pbxRoomThumbnail);
            this.Controls.Add(this.lblRoomType);
            this.Name = "RoomItem";
            this.Size = new System.Drawing.Size(982, 121);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCTABooking;
        private System.Windows.Forms.Label lblRoomDescription;
        private System.Windows.Forms.Label lblRoomDisclaimer;
        private System.Windows.Forms.Label lblRoomCapacity;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.PictureBox pbxRoomThumbnail;
        private System.Windows.Forms.Label lblRoomType;
    }
}
