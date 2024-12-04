using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmBookingServices : Form
    {
        //private void UpdateAvailableServices()
        //{
        //    try
        //    {
        //        flpAvailableServices.Controls.Clear();

        //        string query = $"SELECT * FROM `services` WHERE `status` = 'available' AND `service_id` NOT IN ({reservedServiceIds})";

        //        DataTable results = DatabaseHelper.Select(query);

        //        if (results.Rows.Count > 0)
        //        {
        //            flpAvailableRooms.SuspendLayout();
        //            foreach (DataRow row in results.Rows)
        //            {
        //                selectedRoomId = Convert.ToInt32(row[0]);
        //                AvailableRoomItem availableRoomItem = new AvailableRoomItem(selectedRoomId);

        //                flpAvailableRooms.Controls.Add(availableRoomItem);

        //                availableRoomItem.Width = flpAvailableRooms.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 20;

        //                availableRoomItem.RoomSelected += InsertAvailableRoom;
        //            }
        //            flpAvailableRooms.ResumeLayout();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{this} | UpdateAvailableRooms() | Error: {ex.Message}");
        //    }
        //}

        public frmBookingServices()
        {
            InitializeComponent();
        }

        private void frmBookingServices_Load(object sender, EventArgs e)
        {

        }
    }
}
