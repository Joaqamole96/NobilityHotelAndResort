using System.Windows.Forms;

namespace HotelAndResort.Models.UserControls
{
    public partial class ReservedServiceItem : UserControl
    {
        public ReservedServiceItem(ReservedService reservedService)
        {
            InitializeComponent();

            lblServiceName.Text = reservedService.ServiceName;
            lblServiceCapacity.Text = reservedService.ServiceCapacity.ToString();
            lblServiceDescription.Text = reservedService.ServiceDescription;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
