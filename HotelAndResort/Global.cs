using HotelAndResort.Views;
using System.Windows.Forms;

namespace HotelAndResort
{
    public class Global
    {
        public static Reservation reservation;

        public static Form frmHome = new frmHome();
        public static Form frmRooms = new frmRooms();
        public static Form frmAbout = new frmAboutUsPage();
        public static Form frmContact = new frmContactUsPage();
        public static Form frmLogin = new frmLoginPage();
        public static Form frmBooking = new frmBooking();

        public static void OpenForm(Form currentForm, Form targetForm)
        {
            // Close the current form
            currentForm.Hide();

            // Show current form when the new form is closed
            targetForm.Show();
        }
    }
}
