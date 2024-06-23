using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class ChangePasswordPage : Form
    {
        private static readonly ExceptionHandling exception = new ExceptionHandling();
        private System.Windows.Forms.Timer timer;
        private PasswordChangeConfirmation passwordChangeConfirmation;

        public ChangePasswordPage()
        {
            InitializeComponent();
            InitializeTimer();
            // Attach the event handlers
            // CurrentPasswordTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // NewPasswordTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // ConfirmNewPasswordTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        /*
        // Event handler to check if all fields are not null or empty
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = !string.IsNullOrWhiteSpace(CurrentPasswordTextBox.Text) &&
                                    !string.IsNullOrWhiteSpace(NewPasswordTextBox.Text) &&
                                    !string.IsNullOrWhiteSpace(ConfirmNewPasswordTextBox.Text);
        }*/

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            if (passwordChangeConfirmation != null)
            {
                passwordChangeConfirmation.Close();
                passwordChangeConfirmation = null;
            }

            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();

            this.Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = CurrentPasswordTextBox.Text;
                string newPassword = NewPasswordTextBox.Text;
                string confirmNewPassword = ConfirmNewPasswordTextBox.Text;

                if (Validation.ValidateChangePassword(currentPassword, newPassword, confirmNewPassword))
                {
                    var controller = new UserController();

                    if (controller.ChangePassword(currentPassword, newPassword))
                    {
                        passwordChangeConfirmation = new PasswordChangeConfirmation();
                        passwordChangeConfirmation.Show();
                        timer.Start();
                    }
                    else
                    {
                        Validation.ShowErrorMessage("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            this.Close();
        }
    }
}
