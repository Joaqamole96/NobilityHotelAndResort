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

namespace HotelAndResort.Models.UserControls.PageSpecific.RoomsPage
{
    public partial class RoomItemTab : UserControl
    {
        public RoomItemTab(int primary_key)
        {
            InitializeComponent();

            string query = $"SELECT * FROM `rooms` r JOIN `available_rooms` a ON a.room_id = r.room_id WHERE a.availableroom_id = {primary_key}";

            try
            {
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    lblRoomType.Text = string.Concat(row["room_number"].ToString(), " | ", row["room_type"].ToString());
                    lblRoomCapacity.Text = row["capacity"].ToString();
                    lblRoomDescription.Text = row["description"].ToString();
                    lblRoomPrice.Text = row["price"].ToString();
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
    }
}
