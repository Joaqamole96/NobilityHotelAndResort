using HotelAndResort.Models.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class AvailableServiceItem : UserControl
    {
        // * ---------- User-Defined Attributes and Methods ---------- * //

        // * Attributes * //

        private int service_id;

        public event Action<int> ServiceSelected;

        // * Methods * //

        public AvailableServiceItem(int service_id)
        {
            InitializeComponent();

            this.service_id = service_id;

            string query = $"SELECT * FROM `services` WHERE `service_id` = {this.service_id}";

            try
            {
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    lblServiceName.Text = row["service_name"].ToString();
                    lblServiceCapacity.Text = $"Good for {row["service_capacity"].ToString()} pax";
                    lblServiceDescription.Text = row["service_description"].ToString();
                    lblServicePrice.Text = row["service_price"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found for the specified ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading content: {ex.Message}");
            }
        }

        private void btnCTABooking_Click(object sender, EventArgs e)
        {
            // Invoke a function in BookingForms.cs that adds this service to the selected service
            ServiceSelected?.Invoke(service_id);
        }
    }
}
