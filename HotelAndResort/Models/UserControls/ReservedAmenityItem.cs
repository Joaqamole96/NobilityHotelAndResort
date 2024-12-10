using System;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservedAmenityItem : UserControl
    {
        public int amenityId { get; set; }

        public ReservedAmenity reservedAmenity { get; set; }

        public event Action<int> ReservedAmenityRemoved;

        public ReservedAmenityItem(ReservedAmenity reservedAmenity)
        {
            InitializeComponent();

            amenityId = reservedAmenity.AmenityId;

            lblAmenityName.Text = reservedAmenity.AmenityName;
            lblAmenityCapacity.Text = "Good for " + reservedAmenity.AmenityCapacity.ToString() + "people";
            lblAmenityPrice.Text = "₱ " + reservedAmenity.AmenityPrice;
        }

        public ReservedAmenityItem(ReservedAmenity reservedAmenity, bool displayOnly)
        {
            InitializeComponent();

            amenityId = reservedAmenity.AmenityId;

            lblAmenityName.Text = reservedAmenity.AmenityName;
            lblAmenityCapacity.Text = reservedAmenity.AmenityCapacity.ToString();
            lblAmenityPrice.Text = "₱ " + reservedAmenity.AmenityPrice;

            btnDelete.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ReservedAmenityRemoved?.Invoke(amenityId);
            Dispose();
        }
    }
}
