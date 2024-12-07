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
            DatabaseHelper.Initialize();
        }

        private void btnCTA_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBooking);
        }

        private void btnContentCTA_Rooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRooms);
        }

        private void btnContentCTA_Services_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRooms);
        }

        // Navigation //

        private void lblHome_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmHome);
        }

        private void lblBooking_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBooking);
        }

        private void lblRooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRooms);
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmAbout);
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmContact);
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
