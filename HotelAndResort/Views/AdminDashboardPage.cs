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
    public partial class frmAdminDashboardPage : Form
    {
        public frmAdminDashboardPage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;

            btnNavAdminRooms.FlatStyle = FlatStyle.Flat;
            btnNavAdminRooms.FlatAppearance.BorderSize = 0;

            btnNavAdminReservations.FlatStyle = FlatStyle.Flat;
            btnNavAdminReservations.FlatAppearance.BorderSize = 0;
        }

        private void frmAdminDashboardPage_Load(object sender, EventArgs e)
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

        private void btnNavAdminRooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global);
        }
    }
}
