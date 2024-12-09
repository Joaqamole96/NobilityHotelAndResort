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

            btnCTAServices.FlatStyle = FlatStyle.Flat;
            btnCTAServices.FlatAppearance.BorderSize = 0;

            // DatabaseHelper.Initialize();
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

        private void lblExitProgram_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
