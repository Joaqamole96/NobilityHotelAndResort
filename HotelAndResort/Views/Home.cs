using HotelAndResort.Models.Data;
using System;
using System.Windows.Forms;

namespace HotelAndResort
{
    public partial class frmHome : Form
    {
        // ---------- Inititalization ---------- //

        public frmHome()
        {
            InitializeComponent();
        }

        // ---------- Methods ---------- //

        private void frmHome_Load(object sender, EventArgs e)
        {
            // 0. Initialize database
            // DatabaseHelper.Initialize();
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmHome);
        }

        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmRooms);
        }

        private void btnNavServices_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmServices);
        }

        private void btnNavAbout_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmAbout);
        }

        private void btnNavContact_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmContact);
        }

        private void btnNavLogin_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmLogin);
        }

        private void btnNavExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCTA_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmBookingRooms);
        }

        private void btnContentCTA_Rooms_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmRooms);
        }

        private void btnContentCTA_Services_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmServices);
        }
    }
}
