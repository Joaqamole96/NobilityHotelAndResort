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
    public partial class ItemTabList : UserControl
    {
        public ItemTabList()
        {
            InitializeComponent();
        }

        public void Populate(string itemTabType)
        {
            try
            {
                lblTitle.Text = itemTabType;
                string query = null;

                if (itemTabType == "Rooms")
                {
                    query = "SELECT * FROM `available_rooms` WHERE `is_available` = 1";
                }
                else if (itemTabType == "Services")
                {
                    query = "SELECT * FROM `available_services` WHERE `is_available` = 1";
                }

                DataTable results = DatabaseHelper.Select(query);

                if (results.Rows.Count > 0)
                {
                    flpItemsList.SuspendLayout();
                    foreach (DataRow row in results.Rows)
                    {
                        int primary_key = Convert.ToInt32(row[0]);

                        UserControl itemTab = null;
                        if (itemTabType == "Rooms")
                        {
                            itemTab = new RoomItemTab(primary_key);
                        }
                        else if (itemTabType == "Services")
                        {
                            itemTab = new ServiceItemTab(primary_key);
                        }
                        itemTab.Width = flpItemsList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10;

                        flpItemsList.Controls.Add(itemTab);

                    }
                    flpItemsList.ResumeLayout();
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

        private void ItemTabList_Load(object sender, EventArgs e)
        {

        }
    }
}
