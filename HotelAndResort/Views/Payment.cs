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
    public partial class frmPayment : Form
    {
        public string ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(tbxCardholderName.Text))
                return "Cardholder name is required.";
            if (string.IsNullOrWhiteSpace(tbxCardNumber.Text) || tbxCardNumber.Text.Length != 16 || !tbxCardNumber.Text.All(char.IsDigit))
                return "Card number must be 16 digits.";
            if (!int.TryParse(tbxExpirationMonth.Text, out int month) || month < 1 || month > 12)
                return "Expiration month must be between 1 and 12.";
            if (!int.TryParse(tbxExpirationYear.Text, out int year) || year < DateTime.Now.Year || (year == DateTime.Now.Year && month < DateTime.Now.Month))
                return "Expiration date is invalid.";
            if (string.IsNullOrWhiteSpace(tbxSecurityCode.Text) || tbxSecurityCode.Text.Length < 3 || tbxSecurityCode.Text.Length > 4 || !tbxSecurityCode.Text.All(char.IsDigit))
                return "Security code must be 3 or 4 digits.";
            return null; // No errors
        }

        public frmPayment()
        {
            InitializeComponent();

            lblReservationPrice.Text = frmBooking.reservation.ReservationPrice.ToString();
            lblCheckIn.Text = frmBooking.reservation.CheckInDateTime.ToString();
            lblCheckOut.Text = frmBooking.reservation.CheckOutDateTime.ToString();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateFields();
            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Confirmation confirmation = new Confirmation();
                confirmation.ShowDialog();
                if (confirmation.DialogResult == DialogResult.Yes)
                {
                    Global.OpenForm(this, Global.frmHome);
                }
                else if (confirmation.DialogResult == DialogResult.Cancel)
                {
                    confirmation.Close();
                }
            }
        }
    }
}
