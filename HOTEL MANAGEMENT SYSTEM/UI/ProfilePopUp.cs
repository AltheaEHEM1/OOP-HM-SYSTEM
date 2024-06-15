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
    public partial class ProfilePopUp : Form
    {
        private Form1 _form1;

        public ProfilePopUp(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void ProfilePicturePopUp_Click(object sender, EventArgs e)
        {

        }

        private void NameProfilePopUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewProfileButton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            _form1.Close();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogOutPage logOutPage = new LogOutPage();
            logOutPage.Show();
            _form1.Close();
            this.Close();
        }
    }
}
