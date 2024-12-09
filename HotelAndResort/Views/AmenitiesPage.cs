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
