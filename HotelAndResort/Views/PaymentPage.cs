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
    public partial class frmPaymentPage : Form
    {
        public frmPaymentPage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;
        }

        private void frmPaymentPage_Load(object sender, EventArgs e)
        {
            if (Global.IsLoggedIn)
            {
                btnNavLogin.Text = "Welcome, " + Global.UserName;
            }
            else
            {
                btnNavLogin.Text = "Login";
                Global.OpenForm(this, Global.frmLoginPage);
            }
        }

        private void lblBackBooking_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void lblExitProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
