using HOTEL_MANAGEMENT_SYSTEM.Controllers;
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
            var getdetails = new UserController();

            var employeeNumber = getdetails.RetrieveStoredEmployeeNumber();

            EmailTextBox.Text = getdetails.GetEmployeeName(employeeNumber);
            IDNumberTextBox.Text = employeeNumber;
            PositionTextBox.Text = getdetails.GetUserJobPosition(employeeNumber);
            ScheduleTextBox.Text = "Schedule Text";

        }

        private void UploadPictureButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
