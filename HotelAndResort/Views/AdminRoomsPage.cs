using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
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
    public partial class frmAdminRoomsPage : Form
    {
        public frmAdminRoomsPage()
        {
            InitializeComponent();

            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.FlatAppearance.BorderSize = 0;
        }

        private void frmAdminRoomsPage_Load(object sender, EventArgs e)
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

            try
            {
                string query = $"SELECT * FROM `rooms`";
                DataTable results = DatabaseHelper.Select(query);

                if(results.Rows.Count > 0)
                {
                    foreach (DataRow row in results.Rows)
                    {
                        AdminAvailableRoomItem adminAvailableRoomItem = new AdminAvailableRoomItem(row);
                        flpAdminAvailableRoomItems.Controls.Add(adminAvailableRoomItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading of Available Rooms in Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
