using System;
using System.Net.Mail;
using System.Windows.Forms;
using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using static System.Windows.Forms.DataFormats;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Hide();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordPage changePasswordPage = new ChangePasswordPage();
            changePasswordPage.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            Name.Text = UserSession.EmployeeName;
            JobPosition.Text = UserSession.JobPosition;
            ProfilePictureBox.Image = ImageHelper.ByteArrayToImage(UserSession.ProfilePicture);
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            if (UserSession.JobPosition == "Admin")
            {
                Form_Admin form_admin = new Form_Admin();
                form_admin.Show();
                this.Hide();
            }
            else
            {
                Form_receptionist form_Receptionist = new Form_receptionist();
                form_Receptionist.Show();
                this.Hide();
            }
        }
    }
}
