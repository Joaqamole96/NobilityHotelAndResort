using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void lblExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
