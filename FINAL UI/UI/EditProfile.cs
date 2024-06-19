using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class EditProfile : Form
    {
        private Form_receptionist form_receptionist;

        public EditProfile()
        {
            InitializeComponent();;
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
    }
}
