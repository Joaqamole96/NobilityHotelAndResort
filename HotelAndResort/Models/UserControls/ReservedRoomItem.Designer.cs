namespace HotelAndResort.Models.UserControls
{
    partial class ReservedRoomItem
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomGuestCount = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRoomThumbnail
            // 
            this.pbxRoomThumbnail.BackColor = System.Drawing.Color.Transparent;
            this.pbxRoomThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRoomThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxRoomThumbnail.Location = new System.Drawing.Point(5, 5);
            this.pbxRoomThumbnail.Margin = new System.Windows.Forms.Padding(5);
            this.pbxRoomThumbnail.Name = "pbxRoomThumbnail";
            this.pbxRoomThumbnail.Size = new System.Drawing.Size(75, 75);
            this.pbxRoomThumbnail.TabIndex = 32;
            this.pbxRoomThumbnail.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(281, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(21, 22);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(85, 5);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(193, 22);
            this.lblRoomNumber.TabIndex = 34;
            this.lblRoomNumber.Text = "Room [RoomNumber]";
            // 
            // lblRoomGuestCount
            // 
            this.lblRoomGuestCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomGuestCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomGuestCount.Location = new System.Drawing.Point(85, 27);
            this.lblRoomGuestCount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblRoomGuestCount.Name = "lblRoomGuestCount";
            this.lblRoomGuestCount.Size = new System.Drawing.Size(213, 21);
            this.lblRoomGuestCount.TabIndex = 35;
            this.lblRoomGuestCount.Text = "[RoomGuestCount] pax";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(86, 66);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(108, 14);
            this.lblRoomPrice.TabIndex = 36;
            this.lblRoomPrice.Text = "[RoomDescription]";
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ReservedRoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomGuestCount);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbxRoomThumbnail);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ReservedRoomItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(310, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxRoomThumbnail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomGuestCount;
        private System.Windows.Forms.Label lblRoomPrice;
    }
}
