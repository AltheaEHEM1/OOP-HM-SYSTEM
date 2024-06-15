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
    public partial class ChangePasswordPage : Form
    {
        public ChangePasswordPage()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            PasswordChangeConfirmation passwordChangeConfirmation = new PasswordChangeConfirmation(this);
            passwordChangeConfirmation.Show();
        }

        private void CurrentPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            this.Close();
        }
    }
}
