﻿using System;
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
            lblRoomGuestCount.Text = "Reserved for " + reservedRoom.GuestCount.ToString() + " guest/s";
            lblRoomDescription.Text = reservedRoom.RoomDescription;
        }

        public ReservedRoomItem(ReservedRoom reservedRoom, bool displayOnly)
        {
            InitializeComponent();

            roomId = reservedRoom.RoomId;

            lblRoomNumber.Text = "Room " + reservedRoom.RoomNumber;
            lblRoomGuestCount.Text = "Reserved for " + reservedRoom.GuestCount.ToString() + " guest/s";
            lblRoomDescription.Text = reservedRoom.RoomDescription;
            btnDelete.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ReservedRoomRemoved?.Invoke(roomId);
            Dispose();
        }
    }
}
