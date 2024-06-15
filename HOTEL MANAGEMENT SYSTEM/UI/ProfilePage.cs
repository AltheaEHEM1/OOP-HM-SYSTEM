using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void NameProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IDNumberProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void PositionProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeaderBox_Click(object sender, EventArgs e)
        {

        }

        private void ScheduleHeader_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeSchedule_TextChanged(object sender, EventArgs e)
        {

        }

        private void DaySchedule_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordPage changePasswordPage = new ChangePasswordPage();
            changePasswordPage.Show();
            this.Hide();
        }
    }
}
