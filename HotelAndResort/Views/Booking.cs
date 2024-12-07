using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmBooking : Form
    {
        // * ---------- User-Defined ---------- * //

        // * Attributes * //

        public int guestCount = 1;

        public List<int> reservedAmenityIds = new List<int>();

        public List<int> reservedRoomIds = new List<int>();

        public static Reservation reservation;
        public static ReservationItem reservationItem = null;

        // * Methods * //

        private void UpdateAvailableItems(
            string tableName,
            string statusColumn,
            string capacityColumn,
            string exclusionColumn,
            int guestCount,
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

        private void UpdateAvailableRooms()
        {
            UpdateAvailableItems(
                "rooms",
                "room_status",
                "room_capacity",
                "room_id",
                guestCount,
                reservedRoomIds,
                flpAvailableRooms,
                row => {
                    var availableRoomItem = new AvailableRoomItem(Convert.ToInt32(row["room_id"]))
                    {
                        Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
                    };
                    availableRoomItem.RoomSelected += InsertReservedRoom;
                    flpAvailableRooms.Controls.Add(availableRoomItem);
                });

            UpdateAvailableAmenities(); // Ensure amenities update after rooms
        }

        private void UpdateAvailableAmenities()
        {
            UpdateAvailableItems(
                "amenities", 
                "amenity_status", 
                "amenity_capacity", 
                "amenity_id", 
                guestCount, 
                reservedAmenityIds, 
                flpAvailableAmenities, 
                row => {
                    var availableAmenityItem = new AvailableAmenityItem(Convert.ToInt32(row["amenity_id"]))
                    {
                        Width = flpAvailableAmenities.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
                    };
                    availableAmenityItem.AmenitySelected += InsertReservedAmenity;
                    flpAvailableAmenities.Controls.Add(availableAmenityItem);
                }
             );
        }

        private void UpdateTotalCount()
        {
            // Update the total no. of guests
            guestCount = Convert.ToInt32(nudAdultCount.Value + nudChildrenCount.Value + nudSpecialCount.Value);
            tbxGuestCount.Text = guestCount.ToString();

            // Update the FlowLayoutPanel for available rooms
            UpdateAvailableRooms();
        }

        private void InsertReservedRoom(int room_id)
        {
            // Set the current room_id to the reservedRoomIds for exclusion in search
            reservedRoomIds.Add(room_id);

            try
            {
                string query = $"SELECT * FROM `rooms` WHERE `room_id` = {room_id}";
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    // Create an object ReservedRoom and set its attributes
                    ReservedRoom reservedRoom = new ReservedRoom();
                    SetReservedRoomAttributes(reservedRoom, row);

                    // Invoke method in ReservedRoomItem that adds the selected AvailableRoomItem to it
                    ReservedRoomItem reservedRoomItem = new ReservedRoomItem(reservedRoom);
                    reservationItem.InsertReservedRoom(reservedRoom, reservedRoomItem);
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

            // Update the FlowLayoutPanel for available amenities
            UpdateAvailableRooms();
        }

        private void InsertReservedAmenity(int amenity_id)
        {
            if (reservedRoomIds.Count > 0)
            {
                // Set the current amenity_id to the reservedAmenityIds for exclusion in search
                reservedAmenityIds.Add(amenity_id);

                try
                {
                    string query = $"SELECT * FROM `amenities` WHERE `amenity_id` = {amenity_id}";
                    DataTable result = DatabaseHelper.Select(query);

                    if (result.Rows.Count > 0)
                    {
                        DataRow row = result.Rows[0];

                        // Create and set ReservedAmenity object and its attributes
                        ReservedAmenity reservedAmenity = new ReservedAmenity();
                        SetReservedAmenityAttributes(reservedAmenity, row);

                        // Invoke method in ReservedRoomItem that adds the selected AvailableAmenityItem to it
                        ReservedAmenityItem reservedAmenityItem = new ReservedAmenityItem(reservedAmenity);
                        reservationItem.InsertReservedAmenity(reservedAmenity, reservedAmenityItem);
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

                // Update the FlowLayoutPanel for available amenities
                UpdateAvailableAmenities();
            }
            else
            {
                MessageBox.Show("Booking.cs | InsertReservedAmenity | Error: ReservedRoomItem is null; select a room first.");
            }
        }

        private void SetReservedRoomAttributes(ReservedRoom reservedRoom, DataRow row)
        {
            // Set Reservation attributes
            reservedRoom.RoomId = (int)row["room_id"];
            reservedRoom.RoomNumber = (string)row["room_number"];
            reservedRoom.RoomType = (string)row["room_type"];
            reservedRoom.RoomDescription = (string)row["room_description"];
            reservedRoom.RoomPrice = (decimal)row["room_price"];
            reservedRoom.RoomCapacity = (int)row["room_capacity"];
            reservedRoom.RoomStatus = (string)row["room_status"];

            reservation.AddRoomPrice((decimal)row["room_price"]);
        }

        private void SetReservedAmenityAttributes(ReservedAmenity reservedAmenity, DataRow row)
        {
            // Set Reservation attributes
            reservedAmenity.AmenityId = (int)row["amenity_id"];
            reservedAmenity.AmenityName = (string)row["amenity_name"];
            reservedAmenity.AmenityDescription = (string)row["amenity_description"];
            reservedAmenity.AmenityPrice = (decimal)row["amenity_price"];
            reservedAmenity.AmenityCapacity = (int)row["amenity_capacity"];
            reservedAmenity.AmenityStatus = (string)row["amenity_status"];

            reservation.AddAmenityPrice((decimal)row["amenity_price"]);
        }

        public void DeleteReservedRoomId(int roomId)
        {
            MessageBox.Show("DeleteReservedRoomId(int roomId)");
            reservedRoomIds.Remove(roomId);

            if (reservedRoomIds.Count == 0)
            {
                foreach(var amenityId in reservedAmenityIds)
                {
                    DeleteReservedAmenityId(amenityId);
                }
            }
            UpdateAvailableRooms();
        }

        public void DeleteReservedAmenityId(int amenityId)
        {
            MessageBox.Show("DeleteReservedAmenityId(int amenityId)");
            reservedAmenityIds.Remove(amenityId);
            UpdateAvailableAmenities();
        }

        public void DisplayAvailableRooms()
        {
            lblAvailableRooms.BackColor = System.Drawing.Color.NavajoWhite;
            lblAvailableAmenities.BackColor = System.Drawing.Color.AntiqueWhite;

            lblAvailableRooms.BorderStyle = BorderStyle.None;
            lblAvailableAmenities.BorderStyle = BorderStyle.FixedSingle;

            flpAvailableRooms.Show();
            flpAvailableAmenities.Hide();
        }

        public void DisplayAvailableAmenities()
        {
            lblAvailableAmenities.BackColor = System.Drawing.Color.NavajoWhite;
            lblAvailableRooms.BackColor = System.Drawing.Color.AntiqueWhite;

            lblAvailableAmenities.BorderStyle = BorderStyle.None;
            lblAvailableRooms.BorderStyle = BorderStyle.FixedSingle;

            flpAvailableAmenities.Show();
            flpAvailableRooms.Hide();
        }

        // * ---------- Natural Attributes and Methods ---------- * //

        // * Methods * //

        // Main //

        public frmBooking()
        {
            InitializeComponent();
        }

        private void BookingRooms_Load(object sender, EventArgs e)
        {
            dtpCheckIn.MinDate = DateTime.Now;
            dtpCheckIn.Value = DateTime.Now;

            dtpCheckOut.MinDate = dtpCheckIn.Value;
            dtpCheckOut.Value = dtpCheckIn.Value;

            reservation = new Reservation(dtpCheckIn.Value, dtpCheckOut.Value);
            reservationItem = new ReservationItem(this, reservation);

            flpReservationDetails.Controls.Add(reservationItem);

            UpdateTotalCount();
            DisplayAvailableRooms();
        }

        // Check-in and check-out date //

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOut.MinDate = dtpCheckIn.Value;
            dtpCheckOut.Value = dtpCheckIn.Value;

            reservation = new Reservation(dtpCheckIn.Value, dtpCheckOut.Value);
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            reservation = new Reservation(dtpCheckIn.Value, dtpCheckOut.Value);
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

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        // Navigation //

        private void lblHome_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmHome);
        }

        private void lblBooking_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBooking);
        }

        private void lblRooms_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmRooms);
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmAbout);
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmContact);
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblAvailableItemsRoomTypeControl_Click(object sender, EventArgs e)
        {
            DisplayAvailableRooms();
        }

        private void lblAvailableItemsAmenityTypeControl_Click(object sender, EventArgs e)
        {
            DisplayAvailableAmenities();
        }
    }
}
