using System;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmRoomsPage : Form
    {
        public frmRoomsPage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;

            btnCTABooking1.FlatStyle = FlatStyle.Flat;
            btnCTABooking1.FlatAppearance.BorderSize = 0;
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

        private void lblExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
