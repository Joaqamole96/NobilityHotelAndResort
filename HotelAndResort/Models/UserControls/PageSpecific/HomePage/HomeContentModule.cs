using HotelAndResort.Models.Data;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls.PageSpecific.HomePage
{
    public partial class HomeContentModule : UserControl
    {
        public HomeContentModule(Size size, int homecontent_id)
        {
            InitializeComponent();

            this.Size = size;

            string query = @"
                SELECT 
                    `title`, `heading`, `description`, `button_txt` 
                FROM 
                    `homecontent` 
                WHERE 
                    `homecontent_id` = " + homecontent_id;

            try
            {
                DataTable result = DatabaseHelper.Select(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    lblTitle.Text = row["title"].ToString();
                    lblHeading.Text = row["heading"].ToString();
                    lblDescription.Text = row["description"].ToString();
                    btnCTA.Text = row["button_txt"].ToString();
                }
                else
                {
                    MessageBox.Show(this.Name + ": No data found for the specified ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.Name + $"Error loading content: {ex.Message}");
            }
        }

        public HomeContentModule(Size size)
        {
            InitializeComponent();

            this.Size = size;

            lblTitle.Dispose();
            lblHeading.Dispose();
            lblDescription.Dispose();
            btnCTA.Dispose();
        }
    }
}
