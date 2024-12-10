namespace HotelAndResort.Models.UserControls
{
    partial class AdminReservedAmenityItem
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
            this.lblAmenityPrice = new System.Windows.Forms.Label();
            this.lblAmenityName = new System.Windows.Forms.Label();
            this.pbxAmenityThumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmenityThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmenityPrice
            // 
            this.lblAmenityPrice.AutoSize = true;
            this.lblAmenityPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityPrice.Location = new System.Drawing.Point(132, 70);
            this.lblAmenityPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityPrice.Name = "lblAmenityPrice";
            this.lblAmenityPrice.Size = new System.Drawing.Size(117, 19);
            this.lblAmenityPrice.TabIndex = 28;
            this.lblAmenityPrice.Text = "₱ [AmenityPrice]";
            this.lblAmenityPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmenityName
            // 
            this.lblAmenityName.AutoSize = true;
            this.lblAmenityName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityName.Location = new System.Drawing.Point(132, 9);
            this.lblAmenityName.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityName.Name = "lblAmenityName";
            this.lblAmenityName.Size = new System.Drawing.Size(117, 19);
            this.lblAmenityName.TabIndex = 27;
            this.lblAmenityName.Text = "[AmenityName]";
            this.lblAmenityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxAmenityThumbnail
            // 
            this.pbxAmenityThumbnail.Location = new System.Drawing.Point(9, 9);
            this.pbxAmenityThumbnail.Name = "pbxAmenityThumbnail";
            this.pbxAmenityThumbnail.Size = new System.Drawing.Size(120, 80);
            this.pbxAmenityThumbnail.TabIndex = 26;
            this.pbxAmenityThumbnail.TabStop = false;
            // 
            // AdminReservedAmenityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAmenityPrice);
            this.Controls.Add(this.lblAmenityName);
            this.Controls.Add(this.pbxAmenityThumbnail);
            this.Name = "AdminReservedAmenityItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(275, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmenityThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmenityPrice;
        private System.Windows.Forms.Label lblAmenityName;
        private System.Windows.Forms.PictureBox pbxAmenityThumbnail;
    }
}
