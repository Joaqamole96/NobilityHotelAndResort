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
            Global.OpenForm(this, Global.frmHome);
        }

        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRooms);
        }

        private void btnNavServices_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmServices);
        }

        private void btnNavAbout_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmAbout);
        }

        private void btnNavContact_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmContact);
        }

        private void btnNavLogin_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmLogin);
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
            Global.OpenForm(this, Global.frmBookingRooms);
        }

        private void btnContentCTA_Rooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRooms);
        }

        private void btnContentCTA_Services_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmServices);
        }
    }
}
