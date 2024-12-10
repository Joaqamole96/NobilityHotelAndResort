using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class AdminReservedAmenityItem : UserControl
    {
        public AdminReservedAmenityItem(string amenityName, decimal amenityPrice)
        {
            InitializeComponent();

            lblAmenityName.Text = amenityName;
            lblAmenityPrice.Text = "₱ " + amenityPrice;
        }
    }
}
