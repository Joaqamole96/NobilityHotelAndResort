using HotelAndResort.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls.PageSpecific.RoomsPage
{
    public partial class ServiceItemTab : UserControl
    {
        public ServiceItemTab(int primary_key)
        {
            InitializeComponent();

            string query = $"SELECT * FROM `services` r JOIN `available_services` a ON a.service_id = r.service_id WHERE a.availableservice_id = {primary_key}";

            try
            {
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    lblServiceType.Text = row["service_name"].ToString();
                    lblServiceQuantity.Text = row["quantity"].ToString();
                    lblServiceDescription.Text = row["description"].ToString();
                    lblServicePrice.Text = row["price"].ToString();
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
    }
}
