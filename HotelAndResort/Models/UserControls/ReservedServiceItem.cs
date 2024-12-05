using System;
using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservedServiceItem : UserControl
    {
        public int serviceId { get; set; }

        public ReservedService reservedService { get; set; }

        public event Action<ReservedService> ReservedServiceRemoved;

        public ReservedServiceItem(ReservedService reservedService)
        {
            InitializeComponent();

            this.reservedService = reservedService;
            serviceId = reservedService.ServiceId;

            lblServiceName.Text = reservedService.ServiceName;
            lblServiceCapacity.Text = reservedService.ServiceCapacity.ToString();
            lblServiceDescription.Text = reservedService.ServiceDescription;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            ReservedServiceRemoved?.Invoke(reservedService);
            Dispose();
        }
    }
}
