using HotelAndResort.Models.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class AdminAvailableRoomItem : UserControl
    {
        private int roomId { get; set; }

        public AdminAvailableRoomItem(DataRow row)
        {
            InitializeComponent();

            roomId = (int)row["room_id"];
            lblRoomType.Text = (string)row["room_type"];
            lblRoomNumber.Text = "Room " + (string)row["room_number"];
            switch (row["room_status"])
            {
                case "available":
                    cobxChangeStatus.Text = "Available";
                    break;
                case "reserved":
                    cobxChangeStatus.Text = "Reserved";
                    break;
                case "maintenance":
                    cobxChangeStatus.Text = "Under Maintenance";
                    break;
            }
        }

        private void btnChangeStatus_Click(object sender, System.EventArgs e)
        {
            string newRoomStatus = null;
            switch(cobxChangeStatus.SelectedText)
            {
                case "Available":
                    newRoomStatus = "available";
                    break;
                case "Reserved":
                    newRoomStatus = "reserved";
                    break;
                case "Under Maintenance":
                    newRoomStatus = "maintenance";
                    break;
            }
            try
            {
                string query = $"UPDATE `rooms` SET `room_status` = {newRoomStatus} WHERE `room_id` = {roomId}";
                DatabaseHelper.Execute(query);

                MessageBox.Show("Room status successfully changed.", "Room Status Change in Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Status Change in Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
