namespace HotelAndResort.Models.UserControls
{
    partial class AvailableAmenityItem
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
            this.lblAmenityDescription = new System.Windows.Forms.Label();
            this.lblAmenityDisclaimer = new System.Windows.Forms.Label();
            this.lblAmenityCapacity = new System.Windows.Forms.Label();
            this.lblAmenityPrice = new System.Windows.Forms.Label();
            this.pbxAmenityThumbnail = new System.Windows.Forms.PictureBox();
            this.lblAmenityName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmenityThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCTABooking
            // 
            this.btnCTABooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTABooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.btnCTABooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTABooking.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTABooking.Location = new System.Drawing.Point(590, 85);
            this.btnCTABooking.Margin = new System.Windows.Forms.Padding(0);
            this.btnCTABooking.Name = "btnCTABooking";
            this.btnCTABooking.Size = new System.Drawing.Size(100, 25);
            this.btnCTABooking.TabIndex = 34;
            this.btnCTABooking.Text = "Select Amenity";
            this.btnCTABooking.UseVisualStyleBackColor = false;
            this.btnCTABooking.Click += new System.EventHandler(this.btnCTABooking_Click);
            // 
            // lblAmenityDescription
            // 
            this.lblAmenityDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmenityDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityDescription.Location = new System.Drawing.Point(166, 80);
            this.lblAmenityDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityDescription.Name = "lblAmenityDescription";
            this.lblAmenityDescription.Size = new System.Drawing.Size(350, 30);
            this.lblAmenityDescription.TabIndex = 33;
            this.lblAmenityDescription.Text = "[AmenityDescription]";
            this.lblAmenityDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAmenityDisclaimer
            // 
            this.lblAmenityDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmenityDisclaimer.AutoSize = true;
            this.lblAmenityDisclaimer.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityDisclaimer.Location = new System.Drawing.Point(589, 40);
            this.lblAmenityDisclaimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityDisclaimer.Name = "lblAmenityDisclaimer";
            this.lblAmenityDisclaimer.Size = new System.Drawing.Size(101, 28);
            this.lblAmenityDisclaimer.TabIndex = 31;
            this.lblAmenityDisclaimer.Text = "per night (Including \r\ntaxes and fees)";
            this.lblAmenityDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmenityCapacity
            // 
            this.lblAmenityCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmenityCapacity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityCapacity.Location = new System.Drawing.Point(166, 32);
            this.lblAmenityCapacity.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityCapacity.Name = "lblAmenityCapacity";
            this.lblAmenityCapacity.Size = new System.Drawing.Size(205, 16);
            this.lblAmenityCapacity.TabIndex = 32;
            this.lblAmenityCapacity.Text = "Good for [AmenityCapacity] pax";
            this.lblAmenityCapacity.Visible = false;
            // 
            // lblAmenityPrice
            // 
            this.lblAmenityPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmenityPrice.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityPrice.Location = new System.Drawing.Point(490, 10);
            this.lblAmenityPrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblAmenityPrice.Name = "lblAmenityPrice";
            this.lblAmenityPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmenityPrice.Size = new System.Drawing.Size(200, 25);
            this.lblAmenityPrice.TabIndex = 30;
            this.lblAmenityPrice.Text = "₱ [AmenityPrice]";
            this.lblAmenityPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxAmenityThumbnail
            // 
            this.pbxAmenityThumbnail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxAmenityThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAmenityThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxAmenityThumbnail.Location = new System.Drawing.Point(10, 10);
            this.pbxAmenityThumbnail.Margin = new System.Windows.Forms.Padding(5);
            this.pbxAmenityThumbnail.Name = "pbxAmenityThumbnail";
            this.pbxAmenityThumbnail.Size = new System.Drawing.Size(150, 100);
            this.pbxAmenityThumbnail.TabIndex = 29;
            this.pbxAmenityThumbnail.TabStop = false;
            // 
            // lblAmenityName
            // 
            this.lblAmenityName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityName.Location = new System.Drawing.Point(165, 10);
            this.lblAmenityName.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityName.Name = "lblAmenityName";
            this.lblAmenityName.Size = new System.Drawing.Size(225, 22);
            this.lblAmenityName.TabIndex = 28;
            this.lblAmenityName.Text = "[AmenityName]";
            this.lblAmenityName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AvailableAmenityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCTABooking);
            this.Controls.Add(this.lblAmenityDescription);
            this.Controls.Add(this.lblAmenityDisclaimer);
            this.Controls.Add(this.lblAmenityCapacity);
            this.Controls.Add(this.lblAmenityPrice);
            this.Controls.Add(this.pbxAmenityThumbnail);
            this.Controls.Add(this.lblAmenityName);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "AvailableAmenityItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(700, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmenityThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCTABooking;
        private System.Windows.Forms.Label lblAmenityDescription;
        private System.Windows.Forms.Label lblAmenityDisclaimer;
        private System.Windows.Forms.Label lblAmenityCapacity;
        private System.Windows.Forms.Label lblAmenityPrice;
        private System.Windows.Forms.PictureBox pbxAmenityThumbnail;
        private System.Windows.Forms.Label lblAmenityName;
    }
}
