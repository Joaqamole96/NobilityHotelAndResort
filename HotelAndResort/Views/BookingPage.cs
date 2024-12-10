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

        public static Reservation reservation = new Reservation();
        public static ReservationItem reservationItem = null;

        // ----- Attributes ----- //


        public int guestCount = 1;
        public int adultCount = 1;
        public int childCount = 0;
        public int specialCount = 0;

        public List<int> reservedRoomIds = new List<int>();
        public List<int> reservedAmenityIds = new List<int>();

        // ----- Methods ----- //

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
            reservedRoom.ReservedRoomPrice = (Convert.ToInt32(tbxSpecialCount.Text) > 0) ? (decimal)row["room_price"] * 0.8m : (decimal)row["room_price"];
            
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
            UpdateAvailableItems(
                "amenities",
                "amenity_status",
                "amenity_capacity",
                "amenity_id",
                guestCount,
                reservedAmenityIds,
                flpAvailableAmenities,
                row =>
                {
                    var availableAmenityItem = new AvailableAmenityItem(Convert.ToInt32(row["amenity_id"]))
                    {
                        Width = flpAvailableAmenities.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
                    };
                    availableAmenityItem.AmenitySelected += AddReservedAmenity;
                    flpAvailableAmenities.Controls.Add(availableAmenityItem);
                }
            );
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
                row =>
                {
                    var availableRoomItem = new AvailableRoomItem(Convert.ToInt32(row["room_id"]))
                    {
                        Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20
                    };
                    availableRoomItem.RoomSelected += AddReservedRoom;
                    flpAvailableRooms.Controls.Add(availableRoomItem);
                }
            );
            UpdateAvailableAmenities();
        }

        private void UpdateGuestCount()
        {
            // Update the total no. of guests
            guestCount = Convert.ToInt32(tbxAdultCount.Text) + Convert.ToInt32(tbxChildCount.Text) + Convert.ToInt32(tbxSpecialCount.Text);
          
            tbxAdultCount.Text = adultCount.ToString();
            tbxChildCount.Text = childCount.ToString();
            tbxSpecialCount.Text = specialCount.ToString();
            tbxGuestCount.Text = guestCount.ToString();
            // need numericUpDown and textBox controls for the 3 guest counts and total guest count

            // Update the FlowLayoutPanel for available rooms
            UpdateAvailableRooms();
        }

        public void ResetGuestCount()
        {
            // Reset guestCount
            tbxAdultCount.Text = "1";
            tbxChildCount.Text = "0";
            tbxSpecialCount.Text = "0";
            UpdateGuestCount();
        }

        // + ReservedRoom object, reservedRoomItem user control, reservedRoomId int in reservedRoomIds
        public void AddReservedRoom(int roomId)
        {
            try
            {
                string query = $"SELECT * FROM `rooms` WHERE `room_id` = {roomId}";
                DataTable results = DatabaseHelper.Select(query);

                if(results.Rows.Count > 0)
                {
                    DataRow row = results.Rows[0];

                    // Create an object ReservedRoom and set its attributes
                    ReservedRoom reservedRoom = new ReservedRoom();
                    SetReservedRoomAttributes(reservedRoom, row);

                    // Invoke method in ReservedRoomItem that adds the selected AvailableRoomItem to it
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
            lblAvailableRoomsControl.BackColor = System.Drawing.Color.White;
            lblAvailableAmenitiesControl.BackColor = System.Drawing.Color.Black;

            lblAvailableRoomsControl.ForeColor = System.Drawing.Color.Black;
            lblAvailableAmenitiesControl.ForeColor = System.Drawing.Color.White;

            flpAvailableRooms.Show();
            flpAvailableAmenities.Hide();
        }

        public void DisplayAvailableAmenities()
        {
            lblAvailableAmenitiesControl.BackColor = System.Drawing.Color.White;
            lblAvailableRoomsControl.BackColor = System.Drawing.Color.Black;

            lblAvailableAmenitiesControl.ForeColor = System.Drawing.Color.Black;
            lblAvailableRoomsControl.ForeColor = System.Drawing.Color.White;

            flpAvailableAmenities.Show();
            flpAvailableRooms.Hide();
        }

        public frmBookingPage()
        {
            InitializeComponent();
        }

        private void frmBookingPage_Load(object sender, EventArgs e)
        {
            dtpCheckInDate.MinDate = DateTime.Now;
            dtpCheckInDate.Value = DateTime.Now;

            dtpCheckOutDate.MinDate = dtpCheckInDate.Value;
            dtpCheckOutDate.Value = dtpCheckInDate.Value;

            reservationItem = new ReservationItem(this, reservation);
           
            pnlReservationDetails.Controls.Add(reservationItem);

            UpdateGuestCount();
            DisplayAvailableRooms();
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

        private void pbxSubtractAdultCount_Click(object sender, EventArgs e)
        {
            if (adultCount > 1)
            {
                adultCount -= 1;
                tbxAdultCount.Text = adultCount.ToString();
                UpdateGuestCount();
            }
        }

        private void pbxAddAdultCount_Click(object sender, EventArgs e)
        {
            adultCount += 1;
            tbxAdultCount.Text = adultCount.ToString();
            UpdateGuestCount();
        }

        private void pbxSubtractChildCount_Click(object sender, EventArgs e)
        {
            if (childCount > 0)
            {
                childCount -= 1;
                tbxChildCount.Text = childCount.ToString();
                UpdateGuestCount();
            }
        }

        private void pbxAddChildCount_Click(object sender, EventArgs e)
        {
            childCount += 1;
            tbxChildCount.Text = childCount.ToString();
            UpdateGuestCount();
        }

        private void pbxSubtractSpecialCount_Click(object sender, EventArgs e)
        {
            if (specialCount > 0)
            {
                specialCount -= 1;
                tbxSpecialCount.Text = specialCount.ToString();
                UpdateGuestCount();
            }
        }

        private void pbxAddSpecialCount_Click(object sender, EventArgs e)
        {
            specialCount += 1;
            tbxSpecialCount.Text = specialCount.ToString();
            UpdateGuestCount();
        }

        private void lblAvailableRoomsControl_Click(object sender, EventArgs e)
        {
            DisplayAvailableRooms();
        }

        private void lblAvailableAmenitiesControl_Click(object sender, EventArgs e)
        {
            DisplayAvailableAmenities();
        }

        private void btnCTABooking_Click(object sender, EventArgs e)
        {
            if (reservedRoomIds.Count > 0)
            {
                Global.OpenForm(this, Global.frmPaymentPage);
            }
            else
            {
                MessageBox.Show("Select a room first.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOutDate.MinDate = dtpCheckInDate.Value;
            dtpCheckOutDate.Value = dtpCheckInDate.Value;

            reservation.CheckInDateTime = dtpCheckInDate.Value;
            reservation.CheckOutDateTime = dtpCheckOutDate.Value;
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            reservation.CheckInDateTime = dtpCheckInDate.Value;
            reservation.CheckOutDateTime = dtpCheckOutDate.Value;
        }
    }
}
