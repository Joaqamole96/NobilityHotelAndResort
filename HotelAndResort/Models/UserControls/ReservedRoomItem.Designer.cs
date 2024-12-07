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
            this.lblRoomCapacity = new System.Windows.Forms.Label();
            this.lblRoomDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRoomThumbnail
            // 
            this.pbxRoomThumbnail.BackColor = System.Drawing.Color.Linen;
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
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(281, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(21, 22);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(85, 5);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(193, 22);
            this.lblRoomNumber.TabIndex = 34;
            this.lblRoomNumber.Text = "Room [RoomNumber]";
            // 
            // lblRoomCapacity
            // 
            this.lblRoomCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomCapacity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCapacity.Location = new System.Drawing.Point(86, 27);
            this.lblRoomCapacity.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblRoomCapacity.Name = "lblRoomCapacity";
            this.lblRoomCapacity.Size = new System.Drawing.Size(213, 16);
            this.lblRoomCapacity.TabIndex = 35;
            this.lblRoomCapacity.Text = "[RoomCapacity] pax";
            this.lblRoomCapacity.Visible = false;
            // 
            // lblRoomDescription
            // 
            this.lblRoomDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDescription.Location = new System.Drawing.Point(86, 53);
            this.lblRoomDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomDescription.Name = "lblRoomDescription";
            this.lblRoomDescription.Size = new System.Drawing.Size(216, 27);
            this.lblRoomDescription.TabIndex = 36;
            this.lblRoomDescription.Text = "[RoomDescription]";
            this.lblRoomDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ReservedRoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.lblRoomDescription);
            this.Controls.Add(this.lblRoomCapacity);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbxRoomThumbnail);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ReservedRoomItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(310, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxRoomThumbnail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomCapacity;
        private System.Windows.Forms.Label lblRoomDescription;
    }
}
