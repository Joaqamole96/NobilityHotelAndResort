using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls.PageSpecific.RoomsPage;
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
    public partial class frmBookingRooms : Form
    {
        public static int totalCount = 1;

        public frmBookingRooms()
        {
            InitializeComponent();
        }

        private void UpdateTotalCount()
        {
            totalCount = Convert.ToInt32(nudAdultCount.Value + nudChildrenCount.Value + nudSpecialCount.Value);
            tbxTotalCount.Text = Convert.ToString(totalCount);
        }

        private void LoadAvailableRooms()
        {
            //try
            //{
            //    string query = null;
            //    query = "SELECT * FROM `available_rooms` WHERE `is_available` = 1";

            //    DataTable results = DatabaseHelper.Select(query);

            //    if (results.Rows.Count > 0)
            //    {
            //        flpItemsList.SuspendLayout();
            //        foreach (DataRow row in results.Rows)
            //        {
            //            int primary_key = Convert.ToInt32(row[0]);

            //            UserControl itemTab = null;
            //            if (itemTabType == "Rooms")
            //            {
            //                itemTab = new RoomItemTab(primary_key);
            //            }
            //            else if (itemTabType == "Services")
            //            {
            //                itemTab = new ServiceItemTab(primary_key);
            //            }
            //            itemTab.Width = flpItemsList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10;

            //            flpItemsList.Controls.Add(itemTab);

            //        }
            //        flpItemsList.ResumeLayout();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No data found for the specified ID.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error loading content: {ex.Message}");
            //}
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOut.MinDate = dtpCheckIn.Value;
        }

        private void BookingRooms_Load(object sender, EventArgs e)
        {
            dtpCheckIn.MinDate = DateTime.Now;
            dtpCheckOut.MinDate = dtpCheckIn.Value;
            UpdateTotalCount();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
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
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nudAdultCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCount();
        }

        private void nudChildrenCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCount();
        }

        private void nudSpecialCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCount();
        }
    }
}
