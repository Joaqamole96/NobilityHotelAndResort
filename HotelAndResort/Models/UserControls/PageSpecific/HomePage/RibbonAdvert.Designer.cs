namespace HotelAndResort.Models.UserControls
{
    partial class RibbonAdvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonAdvert));
            this.lblAdvert = new System.Windows.Forms.Label();
            this.btnCTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdvert
            // 
            this.lblAdvert.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvert.ForeColor = System.Drawing.Color.White;
            this.lblAdvert.Location = new System.Drawing.Point(10, 10);
            this.lblAdvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvert.Name = "lblAdvert";
            this.lblAdvert.Size = new System.Drawing.Size(539, 40);
            this.lblAdvert.TabIndex = 4;
            this.lblAdvert.Text = resources.GetString("lblAdvert.Text");
            this.lblAdvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCTA
            // 
            this.btnCTA.BackColor = System.Drawing.Color.Transparent;
            this.btnCTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTA.ForeColor = System.Drawing.Color.White;
            this.btnCTA.Location = new System.Drawing.Point(573, 10);
            this.btnCTA.Margin = new System.Windows.Forms.Padding(2);
            this.btnCTA.Name = "btnCTA";
            this.btnCTA.Size = new System.Drawing.Size(150, 40);
            this.btnCTA.TabIndex = 6;
            this.btnCTA.Text = " Book Now";
            this.btnCTA.UseVisualStyleBackColor = false;
            // 
            // RibbonAdvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(178)))), ((int)(((byte)(109)))));
            this.Controls.Add(this.btnCTA);
            this.Controls.Add(this.lblAdvert);
            this.Name = "RibbonAdvert";
            this.Size = new System.Drawing.Size(735, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdvert;
        private System.Windows.Forms.Button btnCTA;
    }
}
