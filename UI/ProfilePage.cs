using HOTEL_MANAGEMENT_SYSTEM.Utilities;

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
            }
            else
            {
                Form_receptionist form_Receptionist = new Form_receptionist();
                form_Receptionist.Show();
            }

            this.Hide();
        }
    }
}
