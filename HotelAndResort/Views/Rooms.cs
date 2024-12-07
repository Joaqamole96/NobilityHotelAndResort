using System;
using System.Windows.Forms;

namespace HotelAndResort
{
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmHome);
        }

        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRooms);
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
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCTABooking_Standard_Click(object sender, EventArgs e)
        {

        }

        private void btnCTABooking_Premium_Click(object sender, EventArgs e)
        {

        }

        private void btnCTABooking_Deluxe_Click(object sender, EventArgs e)
        {

        }
    }
}
