using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class EditProfile : Form
    {
        private static readonly ExceptionHandling exception = new ExceptionHandling();
        private System.Windows.Forms.Timer timer;
        private SavedChangesConfirmation savedChangesConfirmation;

        public EditProfile()
        {
            InitializeComponent();
            InitializeTimer();
            // EmailTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // IDNumberTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // PositionTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            // ScheduleTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        /*
        // Event handler to check if all fields are not null or empty
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ConfirmButton.Enabled = !string.IsNullOrWhiteSpace(EmailTextBox.Text) &&
                                    !string.IsNullOrWhiteSpace(IDNumberTextBox.Text) &&
                                    !string.IsNullOrWhiteSpace(ScheduleTextBox.Text)&&
                                    !string.IsNullOrWhiteSpace(ScheduleTextBox.Text);
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
            if (savedChangesConfirmation != null)
            {
                savedChangesConfirmation.Close();
                savedChangesConfirmation = null;
            }

            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();

            this.Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!Validation.ValidateUserDetails(EmailTextBox.Text, IDNumberTextBox.Text, PositionTextBox.Text, ScheduleTextBox.Text))
                {
                    // Validation failed, show error message
                    Validation.ShowErrorMessage("Invalid input. Please check the fields.");
                    return;
                }

                // Update UserSession with new details
                UserSession.EmployeeName = EmailTextBox.Text;
                UserSession.EmployeeNumber = IDNumberTextBox.Text;
                UserSession.JobPosition = PositionTextBox.Text;
                UserSession.Schedule = ScheduleTextBox.Text;

                var controller = new UserController();

                if (controller.EditUser())
                {
                    savedChangesConfirmation = new SavedChangesConfirmation();
                    savedChangesConfirmation.Show();
                    timer.Start();
                }
                else
                {
                    Validation.ShowErrorMessage("Cannot update account.");
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

            this.Hide();
        }

        private void UploadPictureButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    byte[] imageBytes = ImageHelper.ImageToByteArray(Image.FromFile(filePath));
                    UserSession.ProfilePicture = imageBytes;
                    // picturebox.Image = ImageHelper.ByteArrayToImage(imageBytes);
                }
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            EmailTextBox.Text = UserSession.EmployeeName;
            IDNumberTextBox.Text = UserSession.EmployeeNumber;
            PositionTextBox.Text = UserSession.JobPosition;
            ScheduleTextBox.Text = UserSession.Schedule;
        }
    }
}
