﻿namespace HotelAndResort.Views
{
    partial class frmBookingPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblExitProgram = new System.Windows.Forms.Label();
            this.btnNavLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBackHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblExitProgram);
            this.pnlTopBar.Controls.Add(this.btnNavLogin);
            this.pnlTopBar.Controls.Add(this.label2);
            this.pnlTopBar.Controls.Add(this.pbxLogo);
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1280, 100);
            this.pnlTopBar.TabIndex = 11;
            // 
            // lblExitProgram
            // 
            this.lblExitProgram.AutoSize = true;
            this.lblExitProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExitProgram.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitProgram.Location = new System.Drawing.Point(1250, 6);
            this.lblExitProgram.Name = "lblExitProgram";
            this.lblExitProgram.Size = new System.Drawing.Size(24, 26);
            this.lblExitProgram.TabIndex = 18;
            this.lblExitProgram.Text = "X";
            this.lblExitProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExitProgram.Click += new System.EventHandler(this.lblExitProgram_Click);
            // 
            // btnNavLogin
            // 
            this.btnNavLogin.BackColor = System.Drawing.Color.Black;
            this.btnNavLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLogin.ForeColor = System.Drawing.Color.White;
            this.btnNavLogin.Location = new System.Drawing.Point(1095, 40);
            this.btnNavLogin.Name = "btnNavLogin";
            this.btnNavLogin.Size = new System.Drawing.Size(100, 40);
            this.btnNavLogin.TabIndex = 11;
            this.btnNavLogin.Text = "Login";
            this.btnNavLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "by Resortify";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Location = new System.Drawing.Point(45, 30);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(50, 50);
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nobility Hotel and Resort";
            // 
            // lblBackHome
            // 
            this.lblBackHome.AutoSize = true;
            this.lblBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackHome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackHome.Location = new System.Drawing.Point(61, 114);
            this.lblBackHome.Name = "lblBackHome";
            this.lblBackHome.Size = new System.Drawing.Size(145, 23);
            this.lblBackHome.TabIndex = 17;
            this.lblBackHome.Text = "< Return to Home";
            this.lblBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBackHome.Click += new System.EventHandler(this.lblNavHome_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(45, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 150);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(25, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 300);
            this.panel1.TabIndex = 12;
            // 
            // frmBookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBackHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking | Nobility Hotel and Resort";
            this.Load += new System.EventHandler(this.frmBookingPage_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblExitProgram;
        private System.Windows.Forms.Label lblBackHome;
        private System.Windows.Forms.Button btnNavLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}