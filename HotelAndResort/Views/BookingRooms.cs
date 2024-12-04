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

        public static int reservedRoomId;
        public static ReservationItem reservationItem = null;

        // * Methods * //

        private void UpdateAvailableRooms()
        {
            try
            {
                // Suspend the FlowLayoutPanel
                flpAvailableRooms.SuspendLayout();

                // Fetch all available rooms that can hold the no. of guests and are currently not selected
                string query = $"SELECT * FROM `rooms` WHERE `status` = 'available' AND `capacity` >= {totalCount} AND `room_id` != {reservedRoomId}";
                DataTable results = DatabaseHelper.Select(query);

                if (results.Rows.Count > 0)
                {
                    // Clear the FlowLayoutPanel
                    flpAvailableRooms.Controls.Clear();

                    foreach (DataRow row in results.Rows)
                    {
                        // Add the available room to the FlowLayoutPanel as an AvailableRoomItem
                        reservedRoomId = Convert.ToInt32(row[0]);
                        AvailableRoomItem availableRoomItem = new AvailableRoomItem(reservedRoomId);
                        flpAvailableRooms.Controls.Add(availableRoomItem);

                        // Adjust and equip the AvailableRoomItem
                        availableRoomItem.Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20;
                        availableRoomItem.RoomSelected += InsertAvailableRoom;
                    }
                }

                // Resume the FlowLayoutPanel
                flpAvailableRooms.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{this} | UpdateAvailableRooms() | Error: {ex.Message}");
            }
        }

        private void UpdateTotalCount()
        {
            // Update the total no. of guests
            totalCount = Convert.ToInt32(nudAdultCount.Value + nudChildrenCount.Value + nudSpecialCount.Value);
            tbxTotalCount.Text = totalCount.ToString();

            // Update the FlowLayoutPanel for available rooms
            UpdateAvailableRooms();
        }

        public void InsertAvailableRoom(int room_id)
        {
            // Suspend the FlowLayoutPanel
            flpReservationDetails.SuspendLayout();

            // Clear the FlowLayoutPanel
            flpReservationDetails.Controls.Clear();

            // Add the selected AvailableRoomItem as a ReservationItem or, if it already exists, update the ReservationItem
            reservationItem?.Dispose();
            reservationItem = new ReservationItem(room_id);
            flpReservationDetails.Controls.Add(reservationItem);

            // Adjust the ReservationItem
            reservationItem.Dock = DockStyle.Top;

            // Resume the FlowLayoutPanel
            flpReservationDetails.ResumeLayout();

            // Update the FlowLayoutPanel for available rooms
            UpdateAvailableRooms();
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

        // Navigation //

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

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingServices);
        }
    }
}
