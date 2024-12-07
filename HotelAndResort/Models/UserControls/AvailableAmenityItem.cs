using HotelAndResort.Models.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class AvailableAmenityItem : UserControl
    {
        // * ---------- User-Defined Attributes and Methods ---------- * //

        // * Attributes * //

        private int amenity_id;

        public event Action<int> AmenitySelected;

        // * Methods * //

        public AvailableAmenityItem(int amenity_id)
        {
            InitializeComponent();

            this.amenity_id = amenity_id;

            string query = $"SELECT * FROM `amenities` WHERE `amenity_id` = {this.amenity_id}";

            try
            {
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    lblAmenityName.Text = row["amenity_name"].ToString();
                    lblAmenityCapacity.Text = $"Good for {row["amenity_capacity"].ToString()} pax";
                    lblAmenityDescription.Text = row["amenity_description"].ToString();
                    lblAmenityPrice.Text = row["amenity_price"].ToString();
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
            // Invoke a function in BookingForms.cs that adds this amenity to the selected amenity
            AmenitySelected?.Invoke(amenity_id);
        }
    }
}
