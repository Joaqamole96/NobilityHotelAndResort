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
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show($"Error: one or more fields is empty. {input} is empty", type, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string login_username = tbxLoginUsername.Text;
            string login_password = tbxLoginPassword.Text;

            if (ValidateInput("Login", login_username, login_password))
            {
                try
                {
                    string query = $"SELECT * FROM `users` WHERE `user_name` = '{login_username}' AND `password` = '{login_password}'";
                    DataTable results = DatabaseHelper.Select(query);

                    if (results.Rows.Count > 0)
                    {
                        DataRow row = results.Rows[0];

                        Global.IsLoggedIn = true;
                        Global.UserId = (int)row["user_id"];
                        Global.UserName = (string)row["user_name"];
                        string role = (string)row["role"];
                        if (role == "admin")
                        {
                            Global.OpenForm(this, Global.frmAdminDashboardPage);
                        }
                        else
                        {
                            Global.OpenForm(this, Global.frmHomePage);
                        }

                        ClearAllFields();

                        MessageBox.Show("Login successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string regis_username = tbxRegisUsername.Text;
            string email = tbxRegisEmail.Text;
            string phonenumber = tbxRegisPhone.Text;
            string regis_password = tbxRegisPassword.Text;

            if (ValidateInput("Registration", firstname, lastname, regis_username, email, phonenumber, regis_password))
            {
                try
                {
                    string query = $"INSERT INTO `Users` (user_name, first_name, last_name, email, phone_number, password, role) VALUES ('{regis_username}', '{firstname}', '{lastname}', '{email}', '{phonenumber}', '{regis_password}', 'guest')";

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
