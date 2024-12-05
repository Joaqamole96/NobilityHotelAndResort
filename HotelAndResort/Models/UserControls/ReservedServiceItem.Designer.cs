namespace HotelAndResort.Models.UserControls
{
    partial class ReservedServiceItem
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
            this.pbxServiceThumbnail = new System.Windows.Forms.PictureBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServiceCapacity = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxServiceThumbnail
            // 
            this.pbxServiceThumbnail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxServiceThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxServiceThumbnail.Location = new System.Drawing.Point(8, 8);
            this.pbxServiceThumbnail.Margin = new System.Windows.Forms.Padding(5);
            this.pbxServiceThumbnail.Name = "pbxServiceThumbnail";
            this.pbxServiceThumbnail.Size = new System.Drawing.Size(75, 75);
            this.pbxServiceThumbnail.TabIndex = 25;
            this.pbxServiceThumbnail.TabStop = false;
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(88, 8);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(189, 22);
            this.lblServiceName.TabIndex = 26;
            this.lblServiceName.Text = "[ServiceName]";
            // 
            // lblServiceCapacity
            // 
            this.lblServiceCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceCapacity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCapacity.Location = new System.Drawing.Point(89, 30);
            this.lblServiceCapacity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblServiceCapacity.Name = "lblServiceCapacity";
            this.lblServiceCapacity.Size = new System.Drawing.Size(213, 16);
            this.lblServiceCapacity.TabIndex = 28;
            this.lblServiceCapacity.Text = "Good for [ServiceCapacity] pax";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.Location = new System.Drawing.Point(89, 50);
            this.lblServiceDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(213, 33);
            this.lblServiceDescription.TabIndex = 29;
            this.lblServiceDescription.Text = "[ServiceDescription]";
            this.lblServiceDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(283, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(21, 22);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ReservedServiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblServiceCapacity);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.pbxServiceThumbnail);
            this.Controls.Add(this.lblServiceDescription);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(310, 0);
            this.Name = "ReservedServiceItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(310, 91);
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxServiceThumbnail;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceCapacity;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Button btnExit;
    }
}
