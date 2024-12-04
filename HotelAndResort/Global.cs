using HotelAndResort.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAndResort
{
    public class Global
    {
        public static Form frmHome = new frmHome();
        public static Form frmRooms = new frmRooms();
        public static Form frmServices = new frmServices();
        public static Form frmAbout = new frmAboutUsPage();
        public static Form frmContact = new frmContactUsPage();
        public static Form frmLogin = new frmLoginPage();
        public static Form frmBookingRooms = new frmBookingRooms();
        public static Form frmBookingServices = new frmBookingServices();

        public static DataTable reservedRoom;
        public static DataTable reservedServices;

        public static void OpenForm(Form currentForm, Form targetForm)
        {
            // Close the current form
            currentForm.Hide();

            // Show current form when the new form is closed
            targetForm.Show();
        }
    }
}
