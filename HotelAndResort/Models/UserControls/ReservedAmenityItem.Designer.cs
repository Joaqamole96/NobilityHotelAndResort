namespace HotelAndResort.Models.UserControls
{
    partial class ReservedAmenityItem
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
            this.lblAmenityDescription = new System.Windows.Forms.Label();
            this.lblAmenityCapacity = new System.Windows.Forms.Label();
            this.lblAmenityName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbxAmenityThumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmenityThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmenityDescription
            // 
            this.lblAmenityDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmenityDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityDescription.Location = new System.Drawing.Point(86, 53);
            this.lblAmenityDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityDescription.Name = "lblAmenityDescription";
            this.lblAmenityDescription.Size = new System.Drawing.Size(222, 27);
            this.lblAmenityDescription.TabIndex = 41;
            this.lblAmenityDescription.Text = "[AmenityDescription]";
            this.lblAmenityDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAmenityCapacity
            // 
            this.lblAmenityCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmenityCapacity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityCapacity.Location = new System.Drawing.Point(86, 30);
            this.lblAmenityCapacity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAmenityCapacity.Name = "lblAmenityCapacity";
            this.lblAmenityCapacity.Size = new System.Drawing.Size(210, 16);
            this.lblAmenityCapacity.TabIndex = 40;
            this.lblAmenityCapacity.Text = "[AmenityCapacity] pax";
            this.lblAmenityCapacity.Visible = false;
            // 
            // lblAmenityName
            // 
            this.lblAmenityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmenityName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenityName.Location = new System.Drawing.Point(85, 5);
            this.lblAmenityName.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmenityName.Name = "lblAmenityName";
            this.lblAmenityName.Size = new System.Drawing.Size(195, 22);
            this.lblAmenityName.TabIndex = 39;
            this.lblAmenityName.Text = "[AmenityName]";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(284, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(21, 22);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbxAmenityThumbnail
            // 
            this.pbxAmenityThumbnail.BackColor = System.Drawing.Color.Linen;
            this.pbxAmenityThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAmenityThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxAmenityThumbnail.Location = new System.Drawing.Point(5, 5);
            this.pbxAmenityThumbnail.Margin = new System.Windows.Forms.Padding(5);
            this.pbxAmenityThumbnail.Name = "pbxAmenityThumbnail";
            this.pbxAmenityThumbnail.Size = new System.Drawing.Size(75, 75);
            this.pbxAmenityThumbnail.TabIndex = 37;
            this.pbxAmenityThumbnail.TabStop = false;
            // 
            // ReservedAmenityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.lblAmenityDescription);
            this.Controls.Add(this.lblAmenityCapacity);
            this.Controls.Add(this.lblAmenityName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbxAmenityThumbnail);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ReservedAmenityItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(313, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmenityThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAmenityDescription;
        private System.Windows.Forms.Label lblAmenityCapacity;
        private System.Windows.Forms.Label lblAmenityName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbxAmenityThumbnail;
    }
}
