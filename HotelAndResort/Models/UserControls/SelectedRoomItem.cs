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
    public partial class SelectedRoomItem : UserControl
    {
        private int room_id;

        public SelectedRoomItem(int room_id)
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

        private void lblRemoveItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
