using HotelAndResort.Models.UserControls;
using System;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();

            lblReservationPrice.Text = frmBooking.reservation.ReservationPrice.ToString();
            lblCheckIn.Text = frmBooking.reservation.CheckInDateTime.ToString();
            lblCheckOut.Text = frmBooking.reservation.CheckOutDateTime.ToString();

            foreach (ReservedRoom reservedRoom in frmBooking.reservationItem.reservedRoomList)
            {
                flpReservedRooms.Controls.Add(new ReservedRoomItem(reservedRoom, true));
            }

            foreach (ReservedAmenity reservedAmenity in frmBooking.reservationItem.reservedAmenityList)
            {
                flpReservedAmenities.Controls.Add(new ReservedAmenityItem(reservedAmenity, true));
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
