using HotelAndResort.Models.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservationItem : UserControl
    {
        private int room_id;
        private double total_price = 0;

        public ReservationItem(int room_id)
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
                    lblRoomCapacity.Text = $"Good for {row["capacity"].ToString()}-{(Convert.ToInt32(row["capacity"]) + 1).ToString()} pax";
                    lblRoomDescription.Text = row["description"].ToString();

                    total_price = Convert.ToDouble(row["price"]);
                    lblTotalPrice.Text = total_price.ToString();

                    // Set the ReservationItem as the current room reservation
                    Global.reservedRoom = result;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
