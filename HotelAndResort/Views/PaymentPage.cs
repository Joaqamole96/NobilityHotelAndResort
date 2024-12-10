using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAndResort.Models.Data;

namespace HotelAndResort.Views
{
    public partial class frmPaymentPage : Form
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

        public frmPaymentPage()
        {
            InitializeComponent();
        }

        private void frmPaymentPage_Load(object sender, EventArgs e)
        {

        }

        private void lblBackBooking_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmBookingPage);
        }

        private void lblExitProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCTAConfirmation_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateFields();
            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmConfirmationModal frmConfirmationModal = new frmConfirmationModal();
                frmConfirmationModal.ShowDialog();
                if (frmConfirmationModal.DialogResult == DialogResult.Yes)
                {
                    Global.OpenForm(this, Global.frmReceiptPage);
                }
                else if (frmConfirmationModal.DialogResult == DialogResult.Cancel)
                {
                    frmConfirmationModal.Close();
                }
            }
        }
    }
}
