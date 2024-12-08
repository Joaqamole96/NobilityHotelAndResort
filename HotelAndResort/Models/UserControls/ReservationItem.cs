using HotelAndResort.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservationItem : UserControl
    {
        // * ---------- User-Defined ---------- * //

        // * Attributes * //

        private Reservation reservation { get; set; }

        public List<ReservedRoom> reservedRoomList = new List<ReservedRoom>();
        public List<ReservedAmenity> reservedAmenityList = new List<ReservedAmenity>();

        private List<ReservedAmenityItem> reservedAmenityItems = new List<ReservedAmenityItem>();

        private frmBooking frmBooking;

        public event Action ReservationRemoved;

        // * Methods * //

        private void UpdateContents()
        {
            // Set labels to current attributes in object reservation
            lblReservationPrice.Text = reservation.ReservationPrice.ToString();
            lblCheckIn.Text = reservation.CheckInDateTime.ToString();
            lblCheckOut.Text = reservation.CheckOutDateTime.ToString();

            // Show or hide FlowLayoutPanel flpReservedRooms based on whether rooms have been reserved or not
            if (reservedRoomList.Count == 0) { flpReservedRooms.Hide(); }
            else { flpReservedRooms.Show(); }

            // Show or hide FlowLayoutPanel flpReservedAmenities based on whether amenities have been reserved or not
            if (reservedAmenityList.Count == 0) { flpReservedAmenities.Hide(); }
            else { flpReservedAmenities.Show(); }
        }

        // Rooms //

        public void InsertReservedRoom(ReservedRoom reservedRoom, ReservedRoomItem reservedRoomItem)
        {
            reservedRoomList.Add(reservedRoom);

            reservedRoomItem.ReservedRoomRemoved += DeleteReservedRoomItem;
            flpReservedRooms.Controls.Add(reservedRoomItem);

            UpdateContents();
        }

        public void DeleteReservedRoomItem(int roomId)
        {
            ReservedRoom roomToRemove = null;

            foreach (ReservedRoom reservedRoom in reservedRoomList)
            {
                if (reservedRoom.RoomId == roomId)
                {
                    roomToRemove = reservedRoom;
                    break;
                }
            }

            if (roomToRemove == null)
            {
                MessageBox.Show("roomId not found.");
                return;
            }

            reservation.RemoveRoomPrice(roomToRemove.ReservedRoomPrice);
            reservedRoomList.Remove(roomToRemove);

            frmBooking.DeleteReservedRoomId(roomId);

            UpdateContents();
        }

        // Amenities //

        public void InsertReservedAmenity(ReservedAmenity reservedAmenity, ReservedAmenityItem reservedAmenityItem)
        {
            // Add the object reservedAmenity to the List reservedAmenityList
            reservedAmenityList.Add(reservedAmenity);

            // Outfit and add the user control reservedAmenityItem
            reservedAmenityItem.ReservedAmenityRemoved += DeleteReservedAmenityItem;
            flpReservedAmenities.Controls.Add(reservedAmenityItem);
            reservedAmenityItems.Add(reservedAmenityItem);

            // Refresh this
            UpdateContents();
        }

        public void DeleteReservedAmenityItem(int amenityId)
        {
            ReservedAmenity amenityToRemove = null;

            foreach (ReservedAmenity reservedAmenity in reservedAmenityList)
            {
                if (reservedAmenity.AmenityId == amenityId)
                {
                    amenityToRemove = reservedAmenity;
                    break;
                }
            }

            if (amenityToRemove == null)
            {
                MessageBox.Show("amenityId not found.");
                return;
            }

            reservation.RemoveAmenityPrice(amenityToRemove.AmenityPrice);
            reservedAmenityList.Remove(amenityToRemove);

            frmBooking.DeleteReservedAmenityId(amenityId);

            UpdateContents();
        }

        public void DeleteReservedAmenityItems()
        {
            foreach (ReservedAmenity reservedAmenity in reservedAmenityList)
            {
                reservation.RemoveAmenityPrice(reservedAmenity.AmenityPrice);
            }

            foreach (ReservedAmenityItem reservedAmenityItem in reservedAmenityItems)
            {
                reservedAmenityItem.Dispose();
            }

            reservedAmenityList.Clear();

            UpdateContents();
        }

        // * ---------- Natural ---------- * //

        // * Methods * //

        public ReservationItem(frmBooking frmBooking, Reservation reservation)
        {
            InitializeComponent();

            this.frmBooking = frmBooking;
            this.reservation = reservation;

            UpdateContents();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ReservationRemoved?.Invoke();
            Dispose();
        }
    }
}
