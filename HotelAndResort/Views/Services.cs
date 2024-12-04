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
    public partial class frmServices : Form
    {
        public frmServices()
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

        private void btnNavServices_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmServices);
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
    }
}
