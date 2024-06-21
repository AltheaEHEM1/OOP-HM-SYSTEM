using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class EditProfile : Form
    {


        public EditProfile()
        {
            InitializeComponent(); ;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SavedChangesConfirmation savedChangesConfirmation = new SavedChangesConfirmation(this);
            savedChangesConfirmation.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            EmailTextBox.Text = UserSession.EmployeeName;
            IDNumberTextBox.Text = UserSession.EmployeeNumber;
            PositionTextBox.Text = UserSession.JobPosition;
            ScheduleTextBox.Text = UserSession.Schedule;
        }

        private void UploadPictureButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
