using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmBookingPage : Form
    {
        /// <summary>
        /// 
        /// User-Defined Objects, Methods, and Attributes
        /// 
        /// </summary>

        // ----- Objects ----- //

        public static Reservation reservation;
        public static ReservationItem reservationItem = null;

        // ----- Attributes ----- //


        public int guestCount = 1;

        public List<int> reservedRoomIds = new List<int>();
        public List<int> reservedAmenityIds = new List<int>();

        // ----- Methods ----- //

        public void SetReservationAttributes()
        {
            // reservation = new Reservation(dtpCheckIn.Value, dtpCheckOut.Value);
            // needs dateTimePicker controls for check-in and check-out
        }

        public void SetReservedRoomAttributes(ReservedRoom reservedRoom, DataRow row)
        {
            reservedRoom.RoomId = (int)row["room_id"];
            reservedRoom.RoomNumber = (string)row["room_number"];
            reservedRoom.RoomType = (string)row["room_type"];
            reservedRoom.RoomDescription = (string)row["room_description"];
            reservedRoom.RoomPrice = (decimal)row["room_price"];
            reservedRoom.RoomCapacity = (int)row["room_capacity"];
            reservedRoom.RoomStatus = (string)row["room_status"];
            reservedRoom.GuestCount = guestCount;
            // reservedRoom.ReservedRoomPrice = (nudSpecialCount.Value > 0) ? (decimal)row["room_price"] * 0.8m : (decimal)row["room_price"];
            // Needs numericUpDown control for seniors/PWDs

            reservation.AddRoomPrice(reservedRoom.ReservedRoomPrice);
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

        public void InitializeReservation()
        {
            SetReservationAttributes();
            // reservationItem = new ReservationItem(this, reservation);
            // needs refactoring of ReservationItem constructor
        }

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

        private void UpdateAvailableAmenities()
        {
            //UpdateAvailableItems(
            //    "amenities",
            //    "amenity_status",
            //    "amenity_capacity",
            //    "amenity_id",
            //    guestCount,
            //    reservedAmenityIds,
            //    flpAvailableAmenities,
            //    row => {
            //        var availableAmenityItem = new AvailableAmenityItem(Convert.ToInt32(row["amenity_id"]))
            //        {
            //            Width = flpAvailableAmenities.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
            //        };
            //        availableAmenityItem.AmenitySelected += InsertReservedAmenity;
            //        flpAvailableAmenities.Controls.Add(availableAmenityItem);
            //    }
            //);
            // Need FlowLayoutPanel of available amenities
        }

        private void UpdateAvailableRooms()
        {
            //UpdateAvailableItems(
            //    "rooms",
            //    "room_status",
            //    "room_capacity",
            //    "room_id",
            //    guestCount,
            //    reservedRoomIds,
            //    flpAvailableRooms,
            //    row => {
            //        var availableRoomItem = new AvailableRoomItem(Convert.ToInt32(row["room_id"]))
            //        {
            //            Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
            //        };
            //        availableRoomItem.RoomSelected += InsertReservedRoom;
            //        flpAvailableRooms.Controls.Add(availableRoomItem);
            //    }
            //);
            // Need FlowLayoutPanel of available rooms
        }

        private void UpdateGuestCount()
        {
            // Update the total no. of guests
            //guestCount = Convert.ToInt32(nudAdultCount.Value + nudChildrenCount.Value + nudSpecialCount.Value);
            //tbxGuestCount.Text = guestCount.ToString();
            // need numericUpDown and textBox controls for the 3 guest counts and total guest count

            // Update the FlowLayoutPanel for available rooms
            //UpdateAvailableRooms();
        }

        public void ResetGuestCount()
        {
            // Reset guestCount
            //nudAdultCount.Value = 1;
            //nudChildrenCount.Value = 0;
            //nudSpecialCount.Value = 0;
            //UpdateTotalCount();
            // Need numericUpDown controls 
        }

        // + ReservedRoom object, reservedRoomItem user control, reservedRoomId int in reservedRoomIds
        public void AddReservedRoom(int roomId)
        {
            try
            {
                string query = $"SELECT * FROM `rooms` WHERE `room_id` = {roomId}";
                DataTable results = DatabaseHelper.Select(query);

                if(results.Rows.Count > 0 )
                {
                    DataRow row = results.Rows[0];

                    ReservedRoom reservedRoom = new ReservedRoom();
                    SetReservedRoomAttributes(reservedRoom, row);

                    ReservedRoomItem reservedRoomItem = new ReservedRoomItem(reservedRoom);
                    reservationItem.InsertReservedRoom(reservedRoom, reservedRoomItem);

                    reservedRoomIds.Add(roomId);

                    UpdateAvailableRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Reserved Room Addition", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddReservedAmenity(int amenityId)
        {
            if (reservedRoomIds.Count > 0)
            {
                try
                {
                    string query = $"SELECT * FROM `amenities` WHERE `amenity_id` = {amenityId}";
                    DataTable result = DatabaseHelper.Select(query);

                    if (result.Rows.Count > 0)
                    {
                        DataRow row = result.Rows[0];

                        ReservedAmenity reservedAmenity = new ReservedAmenity();
                        SetReservedAmenityAttributes(reservedAmenity, row);
                        
                        ReservedAmenityItem reservedAmenityItem = new ReservedAmenityItem(reservedAmenity);
                        reservationItem.InsertReservedAmenity(reservedAmenity, reservedAmenityItem);

                        reservedAmenityIds.Add(amenityId);

                        UpdateAvailableAmenities();
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
            else
            {
                MessageBox.Show("Please select a room first", "Reserved Amenity Addition", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // - reservedRoomId int in reservedRoomIds, reservedAmenityItem (all), reservedAmenityId (all) in reservedAmenityIds
        public void RemoveReservedRoomId(int reservedRoomId)
        {
            reservedRoomIds.Remove(reservedRoomId);
            if (reservedRoomIds.Count == 0)
            {
                reservationItem.DeleteReservedAmenityItems();
                reservedAmenityIds.Clear();
                UpdateAvailableAmenities();
            }
            UpdateAvailableRooms();
        }

        public void RemoveReservedAmenityId(int amenityId)
        {
            reservedAmenityIds.Remove(amenityId);
            UpdateAvailableAmenities();
        }

        public void DisplayAvailableRooms()
        {
            //lblAvailableRooms.BackColor = System.Drawing.Color.NavajoWhite;
            //lblAvailableAmenities.BackColor = System.Drawing.Color.AntiqueWhite;

            //lblAvailableRooms.BorderStyle = BorderStyle.None;
            //lblAvailableAmenities.BorderStyle = BorderStyle.FixedSingle;

            //flpAvailableRooms.Show();
            //flpAvailableAmenities.Hide();
        }

        public void DisplayAvailableAmenities()
        {
            //lblAvailableAmenities.BackColor = System.Drawing.Color.NavajoWhite;
            //lblAvailableRooms.BackColor = System.Drawing.Color.AntiqueWhite;

            //lblAvailableAmenities.BorderStyle = BorderStyle.None;
            //lblAvailableRooms.BorderStyle = BorderStyle.FixedSingle;

            //flpAvailableAmenities.Show();
            //flpAvailableRooms.Hide();
        }

        public frmBookingPage()
        {
            InitializeComponent();
        }

        private void lblNavHome_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmHomePage);
        }

        private void lblExitProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmBookingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
