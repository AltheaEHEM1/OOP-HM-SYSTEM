using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            guna2Panel3.Parent = guna2Panel2;
            guna2Panel3.BackColor = Color.FromArgb(200, Color.White);
            guna2Panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, guna2Panel3.Width, guna2Panel3.Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void hideButton_Click_1(object sender, EventArgs e)
        {
            showButton.BringToFront();
            password.PasswordChar = '\0';
        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            hideButton.BringToFront();
            password.PasswordChar = '*';
        }

        private void confirmButtonShow_Click_1(object sender, EventArgs e)
        {
            confirmButtonHide.BringToFront();
            confirmpassword.PasswordChar = '*';
        }

        private void confirmButtonHide_Click_1(object sender, EventArgs e)
        {
            confirmButtonShow.BringToFront();
            confirmpassword.PasswordChar = '\0';
        }

        private void createAccButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the input fields
                string EmployeeNumber = employeenumber.Text;
                string FullName = fullname.Text;
                string Birthdate = dob.Text;
                string Password = passacc.Text;
                string ConfirmPass = confirmpass.Text;

                // Validate fields are not empty
                if (string.IsNullOrWhiteSpace(EmployeeNumber) || string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Birthdate) ||
                    string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPass))
                {
                    MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate password requirements
                string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[~`!@#$%^&*()_\-+={[}\]|\:;""'<,>.?/]).{8,}$";
                if (!Regex.IsMatch(Password, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate password and confirm password match
                if (Password != ConfirmPass)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // If all validations pass, proceed with account creation
                var controller = new UserController();
                // Catching any exceptions that may occur
                if (!controller.CreateUser(EmployeeNumber, FullName, Birthdate, Password))
                {
                    MessageBox.Show("Error creating your account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoginPage loginPage = new LoginPage();
                loginPage.Show();

                // Hide the CreateAccountForm
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
