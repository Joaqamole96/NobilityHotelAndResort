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
    public partial class AdminReservedRoomItem : UserControl
    {
        public AdminReservedRoomItem(string roomNumber, int guestCount, decimal roomPrice)
        {
            InitializeComponent();

            lblRoomNumber.Text = "Room " + roomNumber;
            lblGuestCount.Text = "Reserved for " + guestCount + " guest/s";
            lblRoomPrice.Text = "₱ " + roomPrice;
        }
    }
}
