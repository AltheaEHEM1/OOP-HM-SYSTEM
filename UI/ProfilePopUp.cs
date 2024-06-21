using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
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
        public ProfilePopUp()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogOutPage logOutPage = new LogOutPage();
            logOutPage.Show();
            this.Close();
        }

        private void ViewProfileButton_Click_1(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            this.Close();
        }

        private void ProfilePopUp_Load(object sender, EventArgs e)
        {
            ProfileNamePopUp.Text = UserSession.EmployeeName;
        }
    }
}
