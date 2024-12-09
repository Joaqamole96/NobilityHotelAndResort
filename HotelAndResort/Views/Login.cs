using HotelAndResort.Models.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelAndResort.Views
{
    public partial class frmLogin : Form
    {
        // ---------- User-Defined ---------- //

        // ----- Methods ----- //

        // Validate User Input
        public bool ValidateInput(string type, params string[] inputs)
        {
            foreach (string input in inputs)
            {
                if (!string.IsNullOrEmpty(input.Trim()))
                {
                    MessageBox.Show("Error: one or more fields is empty.", type, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        // ---------- Natural ---------- //

        // ----- Methods ----- //

        public frmLogin()
        {
            InitializeComponent();
        }

        // Login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxLoginUserName.Text;
            string password = tbxLoginPassword.Text;

            if (ValidateInput("Login", username, password))
            {
                try
                {
                    string query = $"SELECT * FROM `users` WHERE `user_name` = {username} and `password` = {password}";
                    DataTable results = DatabaseHelper.Select(query);

                    if (results.Rows.Count > 0)
                    {
                        Global.UserName = username;
                        MessageBox.Show("Login successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Registration
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = tbxRegisFirstName.Text;
            string lastname = tbxRegisLastName.Text;
            string username = tbxRegisUserName.Text;
            string email = tbxRegisEmail.Text;
            string phonenumber = tbxRegisPhone.Text;
            string password = tbxLoginPassword.Text;

            if (ValidateInput("Registration", firstname, lastname, username, email, phonenumber, password))
            {
                try
                {
                    string query = $"INSERT (`user_name`, `password`, `email`, `phone_number`, `role`) INTO `users` VALUES ({username}, {password}, {email}, {phonenumber}, 'guest')";
                    DatabaseHelper.Execute(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Return to Home Page
        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmHome);
        }
    }
}
