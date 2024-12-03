using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls.PageSpecific.RoomsPage;
using System;
using System.Data;
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
            tbxTotalCount.Text = totalCount.ToString();
        }

        private void LoadRoomsWhere(string condition)
        {
            try
            {
                flpAvailableRooms.Controls.Clear();

                string query = "SELECT * FROM `rooms` WHERE " + condition;

                DataTable results = DatabaseHelper.Select(query);

                if (results.Rows.Count > 0)
                {
                    flpAvailableRooms.SuspendLayout();
                    foreach (DataRow row in results.Rows)
                    {
                        int primary_key = Convert.ToInt32(row[0]);

                        UserControl itemTab = new RoomModule(primary_key);
                        itemTab.Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10;

                        flpAvailableRooms.Controls.Add(itemTab);

                    }
                    flpAvailableRooms.ResumeLayout();
                }
                else
                {
                    MessageBox.Show("No data found for the specified ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading content: {ex.Message}");
            }
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
            LoadRoomsWhere("`status` = 'available'");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadRoomsWhere($"`status` = 'available' AND `capacity` >= {totalCount}");
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
