using HotelAndResort.Models.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class AvailableRoomItem : UserControl
    {
        // * ---------- User-Defined Attributes and Methods ---------- * //

        // * Attributes * //

        private int room_id;

        public event Action<int> RoomSelected;

        // * Methods * //

        public AvailableRoomItem(int room_id)
        {
            InitializeComponent();

            this.room_id = room_id;

            string query = $"SELECT * FROM `rooms` WHERE `room_id` = {this.room_id}";

            try
            {
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    lblRoomType.Text = string.Concat(row["room_number"].ToString(), " | ", row["room_type"].ToString());
                    lblRoomCapacity.Text = $"Good for {row["room_capacity"].ToString()}-{(Convert.ToInt32(row["room_capacity"]) + 1).ToString()} pax";
                    lblRoomDescription.Text = row["room_description"].ToString();
                    lblRoomPrice.Text = row["room_price"].ToString();
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

        private void btnCTABooking_Click(object sender, EventArgs e)
        {
            // Invoke a function in BookingForms.cs that adds this room to the selected room
            RoomSelected?.Invoke(room_id);
        }
    }
}
