using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.UI;
using System.Runtime.InteropServices;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class LoginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public LoginPage()
        {
            InitializeComponent();
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.FromArgb(200, Color.White);
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Createacc_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountform = new CreateAccountForm();
            createAccountform.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string employeeNumber = EmployeeNum.Text;
            string password = PasswordTextbox.Text;

            var controller = new UserController();

            if (string.IsNullOrWhiteSpace(employeeNumber) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (controller.LoginAccount(employeeNumber, password))
            {
                string jobPosition = controller.GetUserJobPosition(employeeNumber);

                if (jobPosition != null)
                {
                    if (jobPosition.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        Form_Admin form_admin = new Form_Admin();
                        form_admin.Show();
                    }
                    else if (jobPosition.Equals("Receptionist", StringComparison.OrdinalIgnoreCase))
                    {
                        Form_receptionist form_receptionist = new Form_receptionist();
                        form_receptionist.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to retrieve user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPassIcon_Click(object sender, EventArgs e)
        {
            HidePassBttn.BringToFront();
            PasswordTextbox.PasswordChar = '*';
        }
        private void HidePassBttn_Click(object sender, EventArgs e)
        {
            ShowPassIcon.BringToFront();
            PasswordTextbox.PasswordChar = '\0';
        }


       
    }
}
