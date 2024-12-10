using HotelAndResort.Models.Data;
using HotelAndResort.Models.UserControls;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmConfirmationModal : Form
    {
        public frmConfirmationModal()
        {
            InitializeComponent();
        }

        private void frmConfirmationModal_Load(object sender, System.EventArgs e)
        {
            lblDetailsReservationPrice.Text = frmBookingPage.reservation.ReservationPrice.ToString();
            lblDetailsCheckInDate.Text = frmBookingPage.reservation.CheckInDateTime.ToString();
            lblDetailsCheckOutDate.Text = frmBookingPage.reservation.CheckOutDateTime.ToString();

            foreach (ReservedRoom reservedRoom in frmBookingPage.reservationItem.reservedRoomList)
            {
                flpReservedRooms.Controls.Add(new ReservedRoomItem(reservedRoom, true));
            }

            foreach (ReservedAmenity reservedAmenity in frmBookingPage.reservationItem.reservedAmenityList)
            {
                flpReservedAmenities.Controls.Add(new ReservedAmenityItem(reservedAmenity, true));
            }
        }

        private void btnCTAReceipt_Click(object sender, System.EventArgs e)
        {
            int insertedReservationId = frmBookingPage.reservation.InsertToDatabase();
            foreach (ReservedRoom reservedRoom in frmBookingPage.reservationItem.reservedRoomList)
            {
                reservedRoom.ReservationId = insertedReservationId;
                reservedRoom.InsertToDatabase();
            }
            foreach (ReservedAmenity reservedAmenity in frmBookingPage.reservationItem.reservedAmenityList)
            {
                reservedAmenity.ReservationId = insertedReservationId;
                reservedAmenity.InsertToDatabase();
            }

            DialogResult = DialogResult.Yes;
        }

        private void btnBackBooking_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
