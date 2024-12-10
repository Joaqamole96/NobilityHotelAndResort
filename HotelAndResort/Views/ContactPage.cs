﻿using System;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmContactPage : Form
    {
        public frmContactPage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;
        }

        private void lblNavHome_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmHomePage);
        }

        private void lblNavRooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRoomsPage);
        }

        private void lblNavAmenities_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmAmenitiesPage);
        }

        private void lblNavBooking_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void lblNavAbout_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmAboutPage);
        }

        private void lblNavContact_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmContactPage);
        }

        private void lblExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmContactPage_Load(object sender, EventArgs e)
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
