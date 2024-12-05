using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservationItem : UserControl
    {
        public List<ReservedService> reservedServices = new List<ReservedService>();

        public void InsertReservedService(ReservedServiceItem reservedServiceItem)
        {
            reservedServiceItem.Dock = DockStyle.Top;
            pnlDetails.Controls.Add(reservedServiceItem);
        }

        public void AddReservedService(ReservedService service)
        {
            reservedServices.Add(service);
        }

        public ReservationItem(Reservation reservation)
        {
            InitializeComponent();

            lblRoomType.Text = reservation.RoomNumber + " | " + reservation.RoomType;
            lblRoomCapacity.Text = reservation.RoomCapacity.ToString();
            lblRoomDescription.Text = reservation.RoomDescription;

            lblReservationPrice.Text = reservation.ReservationPrice.ToString();

            lblCheckIn.Text = reservation.CheckInDateTime.ToString();
            lblCheckOut.Text = reservation.CheckOutDateTime.ToString();
            lblGuests.Text = reservation.GuestCount.ToString() + " guests";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
