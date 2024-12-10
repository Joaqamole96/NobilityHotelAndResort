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

namespace HotelAndResort.Views
{
    public partial class frmLoginPage : Form
    {
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

        public void ClearAllFields()
        {
            tbxLoginUsername.Clear();
            tbxLoginPassword.Clear();
            tbxRegisFirstName.Clear();
            tbxRegisLastName.Clear();
            tbxRegisUsername.Clear();
            tbxRegisEmail.Clear();
            tbxRegisPhone.Clear();
            tbxRegisPassword.Clear();
        }

        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void lblBackHome_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, Global.frmHomePage);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxLoginUsername.Text;
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
                        ClearAllFields();
                        Global.OpenForm(this, Global.frmHomePage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = tbxRegisFirstName.Text;
            string lastname = tbxRegisLastName.Text;
            string username = tbxRegisUsername.Text;
            string email = tbxRegisEmail.Text;
            string phonenumber = tbxRegisPhone.Text;
            string password = tbxLoginPassword.Text;

            if (ValidateInput("Registration", firstname, lastname, username, email, phonenumber, password))
            {
                try
                {
                    string query = $"INSERT (`user_name`, `password`, `email`, `phone_number`, `role`) INTO `users` VALUES ({username}, {password}, {email}, {phonenumber}, 'guest')";
                    DatabaseHelper.Execute(query);

                    MessageBox.Show("Registration successful. Please login again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllFields();
                    Global.OpenForm(this, Global.frmLoginPage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
