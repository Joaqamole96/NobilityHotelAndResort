using System;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmAmenitiesPage : Form
    {
        public frmAmenitiesPage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;

            btnCTABooking1.FlatStyle = FlatStyle.Flat;
            btnCTABooking1.FlatAppearance.BorderSize = 0;

            btnCTABooking2.FlatStyle = FlatStyle.Flat;
            btnCTABooking2.FlatAppearance.BorderSize = 0;

            btnCTABooking3.FlatStyle = FlatStyle.Flat;
            btnCTABooking3.FlatAppearance.BorderSize = 0;

            btnCTABooking4.FlatStyle = FlatStyle.Flat;
            btnCTABooking4.FlatAppearance.BorderSize = 0;

            btnCTABooking5.FlatStyle = FlatStyle.Flat;
            btnCTABooking5.FlatAppearance.BorderSize = 0;
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
            if (Global.IsLoggedIn == true)
            {
                Global.OpenForm(this, Global.frmBookingPage);
            }
            else
            {
                Global.OpenForm(this, Global.frmLoginPage);
            }
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
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCTABooking1_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void btnCTABooking2_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void btnCTABooking3_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void btnCTABooking4_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void btnCTABooking5_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void frmAmenitiesPage_Load(object sender, EventArgs e)
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

        private void btnNavLogin_Click(object sender, EventArgs e)
        {
            if (Global.IsLoggedIn)
            {
                // Reservations.cs
            }
            else
            {
                Global.OpenForm(this, Global.frmLoginPage);
            }
        }
    }
}
