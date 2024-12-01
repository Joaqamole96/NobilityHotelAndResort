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
    public partial class NavigationPanel : UserControl
    {
        public NavigationPanel()
        {
            InitializeComponent();
        }

        public static void OpenForm(Form thisForm, Form form)
        {
            // Close the current form
            thisForm.Hide();

            // Show current form when the new form is closed
            form.Show();
        }

        // Declare events for each button
        public event EventHandler HomeClicked;
        public event EventHandler RoomsClicked;
        public event EventHandler ServicesClicked;
        public event EventHandler AboutClicked;
        public event EventHandler ContactClicked;
        public event EventHandler LoginClicked;

        // Trigger events when buttons are clicked

        private void Home_Click(object sender, EventArgs e)
        {
            HomeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Rooms_Click(object sender, EventArgs e) 
        {
            RoomsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Services_Click(object sender, EventArgs e) => ServicesClicked?.Invoke(this, EventArgs.Empty);

        private void About_Click(object sender, EventArgs e) => AboutClicked?.Invoke(this, EventArgs.Empty);

        private void Contact_Click(object sender, EventArgs e) => ContactClicked?.Invoke(this, EventArgs.Empty);

        private void Login_Click(object sender, EventArgs e) => LoginClicked?.Invoke(this, EventArgs.Empty);
    }
}
