using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmPaymentPage : Form
    {
        public frmPaymentPage()
        {
            InitializeComponent();
        }

        private void lblBackBooking_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }
    }
}
