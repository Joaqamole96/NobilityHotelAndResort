using HotelAndResort.Views;
using System.Windows.Forms;

namespace HotelAndResort
{
    public class Global
    {
        public static Reservation reservation;

        public static Form frmHomePage = new frmHomePage();
        public static Form frmRoomsPage = new frmRoomsPage();
        public static Form frmAmenitiesPage = new frmAmenitiesPage();
        public static Form frmAboutPage = new frmAboutPage();
        public static Form frmContactPage = new frmContactPage();
        public static Form frmBookingPage = new frmBookingPage();
        public static Form frmPaymentPage = new frmPaymentPage();
        public static Form frmConfirmationModal = new frmConfirmationModal();
        public static Form frmReceiptPage = new frmReceiptPage();
        //public static Form frmAdminDashboardPage = new frmAdminDashboardPage();

        public static Form frmHome = new frmHome();
        public static Form frmRooms = new frmRooms();
        public static Form frmBooking = new frmBooking();
        public static Form frmAbout = new frmAboutUsPage();
        public static Form frmContact = new frmContactUsPage();
        public static Form frmLogin = new frmLogin();
        public static Form frmPayment = new frmPayment();

        public static bool IsLoggedIn {  get; set; }
        public static string UserName { get; set; }
        public static string Role { get; set; }

        public static void OpenForm(Form currentForm, Form targetForm)
        {
            // Close the current form
            currentForm.Hide();

            // Show current form when the new form is closed
            targetForm.Show();
        }
    }
}
