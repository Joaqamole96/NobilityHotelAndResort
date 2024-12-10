﻿using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmReceiptPage : Form
    {
        public frmReceiptPage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;
        }

        private void lblNavHome_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmHomePage);
        }

        private void lblNavRooms_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmRoomsPage);
        }

        private void lblNavAmenities_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmAmenitiesPage);
        }

        private void lblNavBooking_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void lblNavAbout_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmAboutPage);
        }

        private void lblNavContact_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmContactPage);
        }

        private void lblExitProgram_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmReceiptPage_Load(object sender, System.EventArgs e)
        {
            if (Global.IsLoggedIn)
            {
                btnNavLogin.Text = "Welcome, " + Global.UserName;
            }
            else
            {
                btnNavLogin.Text = "Login";
            }
        }
    }
}
