using HotelAndResort.Models.Data;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;

            btnCTABooking.FlatStyle = FlatStyle.Flat;
            btnCTABooking.FlatAppearance.BorderSize = 0;

            btnCTARooms.FlatStyle = FlatStyle.Flat;
            btnCTARooms.FlatAppearance.BorderSize = 0;

            btnCTAAmenities.FlatStyle = FlatStyle.Flat;
            btnCTAAmenities.FlatAppearance.BorderSize = 0;

            DatabaseHelper.Initialize();
        }

        private void frmHomePage_Load(object sender, System.EventArgs e)
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

        // Navbar
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

        private void btnNavLogin_Click(object sender, System.EventArgs e)
        {
            if (Global.IsLoggedIn)
            {

            }
            else
            {
                Global.OpenForm(this, Global.frmLoginPage);
            }
        }

        private void lblExitProgram_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // CTAs
        private void btnCTABooking_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void btnCTARooms_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmRoomsPage);
        }

        private void btnCTAAmenities_Click(object sender, System.EventArgs e)
        {
            Global.OpenForm(this, Global.frmAmenitiesPage);
        }
    }
}
