namespace HotelAndResort.Models.UserControls.PageSpecific.RoomsPage
{
    partial class ItemTabList
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpItemsList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 31);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "[Item Type]";
            // 
            // flpItemsList
            // 
            this.flpItemsList.AutoScroll = true;
            this.flpItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpItemsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpItemsList.Location = new System.Drawing.Point(25, 70);
            this.flpItemsList.Name = "flpItemsList";
            this.flpItemsList.Size = new System.Drawing.Size(990, 590);
            this.flpItemsList.TabIndex = 11;
            this.flpItemsList.WrapContents = false;
            // 
            // ItemTabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpItemsList);
            this.Name = "ItemTabList";
            this.Size = new System.Drawing.Size(1036, 676);
            this.Load += new System.EventHandler(this.ItemTabList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpItemsList;
    }
}
