using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            this.Hide();
        }

        private void CreateAcc_Click(object sender, EventArgs e)
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

                // Validate password requirements:
                // - one small letter,              (?=.*[a-z])
                // - one capital letter,            (?=.*[A-Z])
                // - one number,                    (?=.*\d)
                // - one special character, and     (?=.*[~`!@#$%^&*()_\-+={[}\]|\:;""'<,>.?/])
                // - at least 8 characters long     {8,}
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

        private void CreateShowPassBttn_Click(object sender, EventArgs e)
        {
            CreateHidePassBttn.BringToFront();
            passacc.PasswordChar = '*';
        }

        private void CreateHidePassBttn_Click(object sender, EventArgs e)
        {
            CreateShowPassBttn.BringToFront();
            passacc.PasswordChar = '\0';
        }

        private void ConfirmPassShowBttn_Click(object sender, EventArgs e)
        {
            ConfirmPassHideBttn.BringToFront();
            confirmpass.PasswordChar = '*';
        }

        private void ConfirmPassHideBttn_Click(object sender, EventArgs e)
        {
            ConfirmPassShowBttn.BringToFront();
            confirmpass.PasswordChar = '\0';
        }
    }
}
