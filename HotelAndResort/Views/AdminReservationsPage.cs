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
    public partial class frmAdminReservationsPage : Form
    {
        public frmAdminReservationsPage()
        {
            InitializeComponent();
        }

        private void lblBackDashboard_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmAdminDashboardPage);
        }

        private void lblExitProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmAdminReservationsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
