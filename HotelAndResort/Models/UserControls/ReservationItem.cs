using HotelAndResort.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservationItem : UserControl
    {
        // * ---------- User-Defined ---------- * //

        // * Attributes * //

        public int reservedRoomId;

        public List<ReservedService> reservedServices = new List<ReservedService>();
        private frmBookingRooms frmBookingRooms;

        public event Action ReservationRemoved;

        public Reservation reservation;

        // * Methods * //

        public void InsertReservedService(ReservedServiceItem reservedServiceItem)
        {
            reservedServiceItem.Dock = DockStyle.Top;
            reservedServiceItem.ReservedServiceRemoved += DeleteReservedService;

            pnlServices.Controls.Add(reservedServiceItem);

            UpdateContents(reservation);
        }

        public void AddReservedService(ReservedService service)
        {
            reservedServices.Add(service);
        }

        public void DeleteReservedService(ReservedService reservedService)
        {
            int serviceId = reservedService.ReservedServiceId;
            reservedServices.RemoveAll(s => s.ReservedServiceId == serviceId);
            frmBookingRooms.DeleteReservedServiceId(reservedService.ServiceId);

            reservation.RemoveServicePrice(reservedService.ServicePrice);

            UpdateContents(reservation);
        }

        private void UpdateContents(Reservation reservation)
        {
            reservedRoomId = reservation.RoomId;

            lblRoomType.Text = reservation.RoomNumber + " | " + reservation.RoomType;
            lblRoomCapacity.Text = reservation.RoomCapacity.ToString();
            lblRoomDescription.Text = reservation.RoomDescription;

            lblReservationPrice.Text = reservation.ReservationPrice.ToString();

            lblCheckIn.Text = reservation.CheckInDateTime.ToString();
            lblCheckOut.Text = reservation.CheckOutDateTime.ToString();
            lblGuests.Text = reservation.GuestCount.ToString() + " guests";
        }

        // * ---------- Natural ---------- * //

        // * Methods * //

        public ReservationItem(frmBookingRooms frmBookingRooms, Reservation reservation)
        {
            InitializeComponent();

            this.frmBookingRooms = frmBookingRooms;
            this.reservation = reservation;

            UpdateContents(reservation);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ReservationRemoved?.Invoke();
            Dispose();
        }
    }
}
