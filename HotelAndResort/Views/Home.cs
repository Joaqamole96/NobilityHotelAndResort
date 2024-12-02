using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
using HotelAndResort.Models.UserControls.PageSpecific.HomePage;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Size size = new Size(flpHomeContent.Width / 2 - 10, flpHomeContent.Height / 2 - 10);
            flpHomeContent.Controls.Add(new HomeContentModule(size));
            flpHomeContent.Controls.Add(new HomeContentModule(size, 1));
            flpHomeContent.Controls.Add(new HomeContentModule(size, 2));
            flpHomeContent.Controls.Add(new HomeContentModule(size));
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmHome);
        }

        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmRooms);
        }

        private void btnNavServices_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmServices);
        }

        private void btnNavAbout_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmAbout);
        }

        private void btnNavContact_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmContact);
        }

        private void btnNavLogin_Click(object sender, EventArgs e)
        {
            init.OpenForm(this, init.frmLogin);
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
            init.OpenForm(this, init.frmBookingRooms);
        }
    }
}
