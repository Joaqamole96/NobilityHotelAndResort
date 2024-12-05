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
        // * ---------- User-Defined ---------- * //

        // * Attributes * //

        public int guestCount = 1;
        public int reservedRoomId;
        public List<int> reservedServiceIds = new List<int>();

        public static ReservationItem reservationItem = null;
        public static Reservation reservation = new Reservation();

        // * Methods * //

        private void UpdateAvailableItems(
            string tableName, 
            string statusColumn, 
            string capacityColumn, 
            string exclusionColumn, 
            int guestCount, 
            int reservedId, 
            List<int> excludedIds, 
            FlowLayoutPanel panel, 
            Action<DataRow> itemCreator)
        {
            try
            {
                panel.SuspendLayout();

                string excludedIdsList = excludedIds.Count > 0 ? string.Join(",", excludedIds) : "0";
                string query = $@"
                    SELECT 
                        * 
                    FROM 
                        `{tableName}`
                    WHERE 
                        `{statusColumn}` = 'available' 
                            AND 
                        `{capacityColumn}` >= {guestCount} 
                            AND 
                        `{exclusionColumn}` NOT IN ({excludedIdsList}) 
                            AND 
                        `{exclusionColumn}` != {reservedId}
                ";
                DataTable results = DatabaseHelper.Select(query);

                panel.Controls.Clear();
                foreach (DataRow row in results.Rows)
                {
                    itemCreator(row);
                }

                panel.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{nameof(UpdateAvailableItems)} Error: {ex.Message}");
            }
        }

        private void UpdateAvailableServices()
        {
            UpdateAvailableItems(
                "services", 
                "service_status", 
                "service_capacity", 
                "service_id", 
                guestCount, 
                0, 
                reservedServiceIds, 
                flpAvailableServices, 
                row => {
                    var availableServiceItem = new AvailableServiceItem(Convert.ToInt32(row["service_id"]))
                    {
                        Width = flpAvailableServices.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
                    };
                    availableServiceItem.ServiceSelected += InsertReservedService;
                    flpAvailableServices.Controls.Add(availableServiceItem);
                });
        }

        private void UpdateAvailableRooms()
        {
            UpdateAvailableItems(
                "rooms", 
                "room_status", 
                "room_capacity", 
                "room_id", 
                guestCount, 
                reservedRoomId, 
                new List<int>(), 
                flpAvailableRooms, 
                row => {
                    var availableRoomItem = new AvailableRoomItem(Convert.ToInt32(row["room_id"]))
                    {
                        Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
                    };
                    availableRoomItem.RoomSelected += InsertReservation;
                    flpAvailableRooms.Controls.Add(availableRoomItem);
                });

            UpdateAvailableServices(); // Ensure services update after rooms
        }

        private void UpdateTotalCount()
        {
            // Update the total no. of guests
            guestCount = Convert.ToInt32(nudAdultCount.Value + nudChildrenCount.Value + nudSpecialCount.Value);
            tbxGuestCount.Text = guestCount.ToString();

            // Update the FlowLayoutPanel for available rooms
            UpdateAvailableRooms();
        }

        private void InsertReservation(int room_id)
        {
            reservation = new Reservation();

            // Set Reservation attributes
            reservation.CheckInDateTime = dtpCheckIn.Value;
            reservation.CheckOutDateTime = dtpCheckOut.Value;
            reservation.GuestCount = guestCount;
            reservation.ReservationStatus = "draft";

            // Set the current room_id to the reservation_id for exclusion in search
            reservedRoomId = room_id;

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
                    reservationItem = new ReservationItem(this, reservation);
                    flpReservationDetails.Controls.Add(reservationItem);

                    reservedServiceIds.Clear();

                    reservationItem.ReservationRemoved += DeleteReservation;

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

        private void InsertReservedService(int service_id)
        {
            if (reservedRoomId != 0)
            {
                // Set the current service_id to the reservedServiceIds for exclusion in search
                reservedServiceIds.Add(service_id);

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

        private void SetReservationAttributes_Room(DataRow row)
        {
            // Set Reservation attributes
            reservation.RoomId = (int)row["room_id"];
            reservation.RoomNumber = (string)row["room_number"];
            reservation.RoomType = (string)row["room_type"];
            reservation.RoomDescription = (string)row["room_description"];
            reservation.RoomPrice = (decimal)row["room_price"];
            reservation.RoomCapacity = (int)row["room_capacity"];
            reservation.RoomStatus = (string)row["room_status"];

            reservation.ReservationPrice += (decimal)row["room_price"];
        }

        private void SetReservedServiceAttributes(ReservedService reservedService, DataRow row)
        {
            // Set Reservation attributes
            reservedService.ServiceId = (int)row["service_id"];
            reservedService.ServiceName = (string)row["service_name"];
            reservedService.ServiceDescription = (string)row["service_description"];
            reservedService.ServicePrice = (decimal)row["service_price"];
            reservedService.ServiceCapacity = (int)row["service_capacity"];
            reservedService.ServiceStatus = (string)row["service_status"];

            reservation.AddServicePrice((decimal)row["service_price"]);
        }

        public void DeleteReservedServiceId(int serviceId)
        {
            reservedServiceIds.Remove(serviceId);
            UpdateAvailableRooms();
        }

        public void DeleteReservation()
        {
            reservedServiceIds.Clear();

            reservation = null;

            reservedRoomId = 0;
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

        }
    }
}
