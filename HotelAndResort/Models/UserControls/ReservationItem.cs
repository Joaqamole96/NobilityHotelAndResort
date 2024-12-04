using HotelAndResort.Models.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservationItem : UserControl
    {
        //public ReservationItem(int room_id)
        //{
        //    InitializeComponent();

        //    try
        //    {
        //        string query = $"SELECT * FROM `rooms` WHERE `room_id` = {room_id}";
        //        DataTable result = DatabaseHelper.Select(query);

        //        if (result.Rows.Count > 0)
        //        {
        //            DataRow row = result.Rows[0];

        //            lblRoomType.Text = string.Concat(row["room_number"].ToString(), " | ", row["room_type"].ToString());
        //            lblRoomCapacity.Text = $"Good for {row["room_capacity"].ToString()}-{(Convert.ToInt32(row["room_capacity"]) + 1).ToString()} pax";
        //            lblRoomDescription.Text = row["room_description"].ToString();
        //            lblTotalPrice.Text = row["room_price"].ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No data found for the specified ID.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading content: {ex.Message}");
        //    }
        //}

        public ReservationItem(Reservation reservation)
        {
            InitializeComponent();

            //lblRoomType.Text = string.Concat(row["room_number"].ToString(), " | ", row["room_type"].ToString());
            //lblRoomCapacity.Text = $"Good for {row["room_capacity"].ToString()}-{(Convert.ToInt32(row["room_capacity"]) + 1).ToString()} pax";
            //lblRoomDescription.Text = row["room_description"].ToString();
            //lblTotalPrice.Text = row["room_price"].ToString();

            lblRoomType.Text = reservation.RoomNumber + " | " + reservation.RoomType;
            lblRoomCapacity.Text = reservation.RoomCapacity.ToString();
            lblRoomDescription.Text = reservation.RoomDescription;

            lblReservationPrice.Text = reservation.ReservationPrice.ToString();

            lblCheckIn.Text = reservation.CheckInDateTime.ToString();
            lblCheckOut.Text = reservation.CheckOutDateTime.ToString();
            lblGuests.Text = reservation.GuestCount.ToString() + " guests";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
