using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class EditProfile : Form
    {
        private static readonly ExceptionHandling eH = new ExceptionHandling();

        public EditProfile()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                var controller = new UserController();

                var updatedUser = new User
                {
                    EmployeeNumber = IDNumberTextBox.Text,
                    EmployeeName = EmailTextBox.Text,
                    Birthdate = UserSession.Birthdate,
                    JobPosition = PositionTextBox.Text,
                    Schedule = ScheduleTextBox.Text,
                    ProfilePicture = UserSession.ProfilePicture
                };

                MessageBox.Show($"Employee Number = {updatedUser.EmployeeNumber}");
                MessageBox.Show($"Employee Name = {updatedUser.EmployeeName}");
                MessageBox.Show($"Employee Job = {updatedUser.JobPosition}");
                MessageBox.Show($"Employee Schedule = {updatedUser.Schedule}");




                if (controller.EditUser(updatedUser))
                {
                    SavedChangesConfirmation savedChangesConfirmation = new SavedChangesConfirmation(this);
                    savedChangesConfirmation.Show();

                    UserSession.EmployeeNumber = IDNumberTextBox.Text;
                    UserSession.EmployeeName = EmailTextBox.Text;
                    UserSession.JobPosition = PositionTextBox.Text;
                    UserSession.Schedule = ScheduleTextBox.Text;

                    ProfilePage profilePage = new ProfilePage();
                    profilePage.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cant Update Account");
                }
            }
            catch (Exception ex)
            {
                eH.HandleException(ex);
            }
        }

        // Make this a cancel button with cancel prompt
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
                openFileDialog.Filter = "Image Files|*.jpg:*.jpeg:*.png:*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory= true;

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
