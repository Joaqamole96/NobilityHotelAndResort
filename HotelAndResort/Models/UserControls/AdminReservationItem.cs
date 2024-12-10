using HotelAndResort.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class AdminReservationItem : UserControl
    {
        public AdminReservationItem(int reservation_id)
        {
            InitializeComponent();

            //string query = $"SELECT * FROM `reserved_amenities` WHERE `reservation_id` = {reservation_id}";
            //DataTable reservedAmenityResults = DatabaseHelper.Select(query);

            try
            {
                string query = $"SELECT * FROM `reservations` WHERE `reservation_id` = {reservation_id}";
                DataTable reservationResults = DatabaseHelper.Select(query);

                if (reservationResults.Rows.Count > 0)
                {
                    DataRow row = reservationResults.Rows[0];

                    lblReservationId.Text = "#" + (string)row["reservation_id"];

                    lblFullName.Text = (string)row["first_name"] + " " + (string)row["last_name"];
                    lblPhoneNumber.Text = (string)row["phone_number"];

                    lblReservationPrice.Text = (string)row["reservation_price"];
                    lblCheckInDate.Text = (string)row["check_in_date"];
                    lblCheckOutDate.Text = (string)row["check_out_date"];
                    lblNightCount.Text = (string)row["night_count"];
                    lblTotalGuestCount.Text = (string)row["total_guest_count"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieval of Reservation Details in Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string query = $"SELECT * FROM `reserved_rooms` WHERE `reservation_id` = {reservation_id}";
                DataTable reservedRoomResults = DatabaseHelper.Select(query);

                if (reservedRoomResults.Rows.Count > 0)
                {
                    foreach (DataRow row in reservedRoomResults.Rows)
                    {
                        string roomNumber = (string)row["room_number"];
                        int guestCount = (int)row["guest_count"];
                        decimal roomPrice = (decimal)row["room_price"];

                        AdminReservedRoomItem reservedRoomItem = new AdminReservedRoomItem(roomNumber, guestCount, roomPrice);
                        flpReservedRooms.Controls.Add(reservedRoomItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieval of Reserved Room Details in Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string query = $"SELECT * FROM `reserved_amenities` WHERE `reservation_id` = {reservation_id}";
                DataTable reservedAmenityResults = DatabaseHelper.Select(query);

                if (reservedAmenityResults.Rows.Count > 0)
                {
                    foreach (DataRow row in reservedAmenityResults.Rows)
                    {
                        string amenityName = (string)row["amenity_name"];
                        decimal amenityPrice = (decimal)row["amenity_price"];
                        AdminReservedAmenityItem reservedAmenityItem = new AdminReservedAmenityItem(amenityName, amenityPrice);
                        flpReservedAmenities.Controls.Add(reservedAmenityItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieval of Reserved Amenity Details in Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
