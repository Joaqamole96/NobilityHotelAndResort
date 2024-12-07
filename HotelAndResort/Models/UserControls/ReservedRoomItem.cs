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
    public partial class ReservedRoomItem : UserControl
    {
        public int roomId { get; set; }

        public ReservedRoom reservedRoom { get; set; }

        public event Action<int> ReservedRoomRemoved;

        public ReservedRoomItem(ReservedRoom reservedRoom)
        {
            InitializeComponent();

            roomId = reservedRoom.RoomId;

            lblRoomNumber.Text = "Room " + reservedRoom.RoomNumber;
            lblRoomCapacity.Text = reservedRoom.RoomCapacity.ToString();
            lblRoomDescription.Text = reservedRoom.RoomDescription;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ReservedRoomRemoved?.Invoke(roomId);
            Dispose();
        }
    }
}
