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
    public partial class FlowContainer : UserControl
    {
        public FlowContainer()
        {
            InitializeComponent();
        }

        public void Add(UserControl userControl)
        {
            flpFlowContainer.Controls.Add(userControl);
        }
    }
}
