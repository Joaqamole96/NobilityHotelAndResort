namespace HotelAndResort.Models.UserControls
{
    partial class AvailableServiceItem
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
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblServiceDisclaimer = new System.Windows.Forms.Label();
            this.lblServiceCapacity = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.pbxServiceThumbnail = new System.Windows.Forms.PictureBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceThumbnail)).BeginInit();
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
            this.btnCTABooking.Text = "Select Service";
            this.btnCTABooking.UseVisualStyleBackColor = false;
            this.btnCTABooking.Click += new System.EventHandler(this.btnCTABooking_Click);
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.Location = new System.Drawing.Point(166, 80);
            this.lblServiceDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(350, 30);
            this.lblServiceDescription.TabIndex = 33;
            this.lblServiceDescription.Text = "[ServiceDescription]";
            this.lblServiceDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblServiceDisclaimer
            // 
            this.lblServiceDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceDisclaimer.AutoSize = true;
            this.lblServiceDisclaimer.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDisclaimer.Location = new System.Drawing.Point(589, 40);
            this.lblServiceDisclaimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblServiceDisclaimer.Name = "lblServiceDisclaimer";
            this.lblServiceDisclaimer.Size = new System.Drawing.Size(101, 28);
            this.lblServiceDisclaimer.TabIndex = 31;
            this.lblServiceDisclaimer.Text = "per night (Including \r\ntaxes and fees)";
            this.lblServiceDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblServiceCapacity
            // 
            this.lblServiceCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceCapacity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCapacity.Location = new System.Drawing.Point(166, 32);
            this.lblServiceCapacity.Margin = new System.Windows.Forms.Padding(0);
            this.lblServiceCapacity.Name = "lblServiceCapacity";
            this.lblServiceCapacity.Size = new System.Drawing.Size(205, 16);
            this.lblServiceCapacity.TabIndex = 32;
            this.lblServiceCapacity.Text = "Good for [ServiceCapacity] pax";
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServicePrice.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.Location = new System.Drawing.Point(490, 10);
            this.lblServicePrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblServicePrice.Size = new System.Drawing.Size(200, 25);
            this.lblServicePrice.TabIndex = 30;
            this.lblServicePrice.Text = "₱ [ServicePrice]";
            this.lblServicePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxServiceThumbnail
            // 
            this.pbxServiceThumbnail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxServiceThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxServiceThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxServiceThumbnail.Location = new System.Drawing.Point(10, 10);
            this.pbxServiceThumbnail.Margin = new System.Windows.Forms.Padding(5);
            this.pbxServiceThumbnail.Name = "pbxServiceThumbnail";
            this.pbxServiceThumbnail.Size = new System.Drawing.Size(150, 100);
            this.pbxServiceThumbnail.TabIndex = 29;
            this.pbxServiceThumbnail.TabStop = false;
            // 
            // lblServiceName
            // 
            this.lblServiceName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(165, 10);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(225, 22);
            this.lblServiceName.TabIndex = 28;
            this.lblServiceName.Text = "[ServiceName]";
            this.lblServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AvailableServiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCTABooking);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServiceDisclaimer);
            this.Controls.Add(this.lblServiceCapacity);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.pbxServiceThumbnail);
            this.Controls.Add(this.lblServiceName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AvailableServiceItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(700, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCTABooking;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServiceDisclaimer;
        private System.Windows.Forms.Label lblServiceCapacity;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.PictureBox pbxServiceThumbnail;
        private System.Windows.Forms.Label lblServiceName;
    }
}
