using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmBookingRooms : Form
    {
        // * ---------- User-Defined Attributes and Methods ---------- * //

        // * Attributes * //

        public static int totalCount = 1;
        public SelectedRoomItem selectedRoomItem = null;

        // * Methods * //

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
                        int room_id = Convert.ToInt32(row[0]);
                        AvailableRoomItem availableRoomItem = new AvailableRoomItem(room_id);

                        flpAvailableRooms.Controls.Add(availableRoomItem);

                        availableRoomItem.Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10;

                        availableRoomItem.RoomSelected += AddSelectedRoom;
                    }
                    flpAvailableRooms.ResumeLayout();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading content: {ex.Message}");
            }
        }

        private void UpdateTotalCount()
        {
            totalCount = Convert.ToInt32(nudAdultCount.Value + nudChildrenCount.Value + nudSpecialCount.Value);
            tbxTotalCount.Text = totalCount.ToString();
            LoadRoomsWhere($"`status` = 'available' AND `capacity` >= {totalCount}");
        }

        public void AddSelectedRoom(int room_id)
        {
            flpSelectedRooms.SuspendLayout();

            //SelectedRoomItem selectedRoomItem = new SelectedRoomItem(room_id);
            //flpSelectedRooms.Controls.Add(selectedRoomItem);

            //selectedRoomItem.Dock = DockStyle.Top;

            flpSelectedRooms.Controls.Clear();

            if (selectedRoomItem != null)
            {
                DeleteSelectedRoom(selectedRoomItem);
            }
            selectedRoomItem = new SelectedRoomItem(room_id);
            flpSelectedRooms.Controls.Add(selectedRoomItem);

            selectedRoomItem.Dock = DockStyle.Top;

            flpSelectedRooms.ResumeLayout();
        }

        public static void DeleteSelectedRoom(SelectedRoomItem selectedRoomItem)
        {
            selectedRoomItem?.Dispose();
        }

        // * ---------- Natural Attributes and Methods ---------- * //

        // * Methods * //

        // Main //

        public frmBookingRooms()
        {
            InitializeComponent();
        }

        private void BookingRooms_Load(object sender, EventArgs e)
        {
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckIn.MinDate = DateTime.Now;
            dtpCheckOut.Value = dtpCheckIn.Value;
            dtpCheckOut.MinDate = dtpCheckIn.Value;

            UpdateTotalCount();
            LoadRoomsWhere("`status` = 'available'");
        }

        // Check-in and check-out date //

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOut.MinDate = dtpCheckIn.Value;
        }

        // Guests //

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

        // Search Rooms //

        private void btnSearchRooms_Click(object sender, EventArgs e)
        {
            LoadRoomsWhere($"`status` = 'available' AND `capacity` >= {totalCount}");
        }

        // Navigation //

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
    }
}
