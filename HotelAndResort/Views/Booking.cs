using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmBookingRooms : Form
    {
        // * ---------- User-Defined Attributes and Methods ---------- * //

        // * Attributes * //

        public static int guestCount = 1;
        public static int reserved_room_id;
        public static List<int> reserved_service_id = new List<int>();

        public static ReservationItem reservationItem = null;
        public static Reservation reservation = new Reservation();

        // * Methods * //

        private void UpdateAvailableRooms()
        {
            try
            {
                // Suspend the FlowLayoutPanel
                flpAvailableRooms.SuspendLayout();

                // Fetch all available rooms that can hold the no. of guests and are currently not selected
                string query = $"SELECT * FROM `rooms` WHERE `room_status` = 'available' AND `room_capacity` >= {guestCount} AND `room_id` != {reserved_room_id}";
                DataTable results = DatabaseHelper.Select(query);

                if (results.Rows.Count > 0)
                {
                    // Clear the FlowLayoutPanel
                    flpAvailableRooms.Controls.Clear();

                    foreach (DataRow row in results.Rows)
                    {
                        // Add the available room to the FlowLayoutPanel as an AvailableRoomItem
                        AvailableRoomItem availableRoomItem = new AvailableRoomItem(Convert.ToInt32(row["room_id"]));
                        flpAvailableRooms.Controls.Add(availableRoomItem);

                        // Adjust and equip the AvailableRoomItem
                        availableRoomItem.Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20;
                        availableRoomItem.RoomSelected += InsertAvailableRoom;
                    }
                }

                // Resume the FlowLayoutPanel
                flpAvailableRooms.ResumeLayout();

                // Update the available services as well
                UpdateAvailableServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Booking.cs | UpdateAvailableRooms() | Error: {ex.Message}");
            }
        }

        private void UpdateAvailableServices()
        {
            try
            {
                // Suspend the FlowLayoutPanel
                flpAvailableServices.SuspendLayout();

                // Fetch all available services that can hold the no. of guests and are currently not selected
                string reservedIds = reserved_service_id.Count > 0 ? string.Join(",", reserved_service_id) : "0";
                MessageBox.Show(reservedIds);
                string query = $"SELECT * FROM `services` WHERE `service_status` = 'available' AND `service_id` NOT IN ({reservedIds})"; 
                DataTable results = DatabaseHelper.Select(query);

                if (results.Rows.Count > 0)
                {
                    // Clear the FlowLayoutPanel
                    flpAvailableServices.Controls.Clear();

                    foreach (DataRow row in results.Rows)
                    {
                        // Add the available service to the FlowLayoutPanel as an AvailableServiceItem
                        AvailableServiceItem availableServiceItem = new AvailableServiceItem(Convert.ToInt32(row["service_id"]));
                        flpAvailableServices.Controls.Add(availableServiceItem);

                        // Adjust and equip the AvailableServiceItem
                        availableServiceItem.Width = flpAvailableServices.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20;
                        availableServiceItem.ServiceSelected += InsertAvailableService;
                    }
                }

                // Resume the FlowLayoutPanel
                flpAvailableServices.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Booking.cs | UpdateAvailableServices() | Error: {ex.Message}");
            }
        }

        private void UpdateTotalCount()
        {
            // Update the total no. of guests
            guestCount = Convert.ToInt32(nudAdultCount.Value + nudChildrenCount.Value + nudSpecialCount.Value);
            tbxGuestCount.Text = guestCount.ToString();

            // Update the FlowLayoutPanel for available rooms
            UpdateAvailableRooms();
        }

        public void InsertAvailableRoom(int room_id)
        {
            // Set Reservation attributes
            reservation.CheckInDateTime = dtpCheckIn.Value;
            reservation.CheckOutDateTime = dtpCheckOut.Value;
            reservation.GuestCount = guestCount;
            reservation.ReservationStatus = "draft";

            // Set the current room_id to the reservation_id for exclusion in search
            reserved_room_id = room_id;

            // Suspend the FlowLayoutPanel
            flpReservationDetails.SuspendLayout();

            // Clear the FlowLayoutPanel
            flpReservationDetails.Controls.Clear();

            try
            {
                string query = $"SELECT * FROM `rooms` WHERE `room_id` = {room_id}";
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    // Set Reservation attributes
                    SetReservationAttributes_Room(row);

                    // Add the selected AvailableRoomItem as a ReservationItem or, if it already exists, update the ReservationItem
                    reservationItem?.Dispose();
                    reservationItem = new ReservationItem(reservation);
                    flpReservationDetails.Controls.Add(reservationItem);

                    // Adjust the ReservationItem
                    reservationItem.Dock = DockStyle.Top;
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

            // Resume the FlowLayoutPanel
            flpReservationDetails.ResumeLayout();

            // Update the FlowLayoutPanel for available rooms
            UpdateAvailableRooms();
        }

        public void InsertAvailableService(int service_id)
        {
            // Set the current service_id to the reserved_service_id for exclusion in search
            reserved_service_id.Add(service_id);

            if (reservationItem != null)
            {
                try
                {
                    string query = $"SELECT * FROM `services` WHERE `service_id` = {service_id}";
                    DataTable result = DatabaseHelper.Select(query);

                    if (result.Rows.Count > 0)
                    {
                        DataRow row = result.Rows[0];

                        // Create and set ReservedService object and its attributes
                        ReservedService reservedService = new ReservedService();
                        SetReservedServiceAttributes(reservedService, row);

                        // Add new ReservedService object
                        reservationItem.AddReservedService(reservedService);

                        // Invoke method in ReservationItem that adds the selected AvailableServiceItem to it
                        ReservedServiceItem reservedServiceItem = new ReservedServiceItem(reservedService);
                        reservationItem.InsertReservedService(reservedServiceItem);
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

                // Update the FlowLayoutPanel for available services
                UpdateAvailableServices();
            }
            else
            {
                MessageBox.Show("Booking.cs | InsertAvailableService | Error: ReservationItem is null; select a room first.");
            }
        }

        public void SetReservationAttributes_Room(DataRow row)
        {
            // Set Reservation attributes
            reservation.RoomNumber = (string)row["room_number"];
            reservation.RoomType = (string)row["room_type"];
            reservation.RoomDescription = (string)row["room_description"];
            reservation.RoomPrice = (decimal)row["room_price"];
            reservation.RoomCapacity = (int)row["room_capacity"];
            reservation.RoomStatus = (string)row["room_status"];

            reservation.ReservationPrice += (decimal)row["room_price"];
        }

        public void SetReservedServiceAttributes(ReservedService reservedService, DataRow row)
        {
            // Set Reservation attributes
            reservedService.ServiceId = (int)row["service_id"];
            reservedService.ServiceName = (string)row["service_name"];
            reservedService.ServiceDescription = (string)row["service_description"];
            reservedService.ServicePrice = (decimal)row["service_price"];
            reservedService.ServiceCapacity = (int)row["service_capacity"];
            reservedService.ServiceStatus = (string)row["service_status"];
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

        }
    }
}
