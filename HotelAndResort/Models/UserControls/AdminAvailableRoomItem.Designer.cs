namespace HotelAndResort.Models.UserControls
{
    partial class AdminAvailableRoomItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.cobxChangeStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.lblRoomType.Location = new System.Drawing.Point(176, 24);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(114, 26);
            this.lblRoomType.TabIndex = 23;
            this.lblRoomType.Text = "[RoomType]";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.lblRoomNumber.Location = new System.Drawing.Point(177, 55);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(163, 21);
            this.lblRoomNumber.TabIndex = 24;
            this.lblRoomNumber.Text = "Room [RoomNumber]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(575, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Room Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.btnChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeStatus.Location = new System.Drawing.Point(579, 90);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(96, 29);
            this.btnChangeStatus.TabIndex = 27;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // cobxChangeStatus
            // 
            this.cobxChangeStatus.FormattingEnabled = true;
            this.cobxChangeStatus.Location = new System.Drawing.Point(525, 55);
            this.cobxChangeStatus.Name = "cobxChangeStatus";
            this.cobxChangeStatus.Size = new System.Drawing.Size(150, 21);
            this.cobxChangeStatus.TabIndex = 28;
            this.cobxChangeStatus.Text = "Available";
            // 
            // AdminAvailableRoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.cobxChangeStatus);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminAvailableRoomItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(700, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.ComboBox cobxChangeStatus;
    }
}
