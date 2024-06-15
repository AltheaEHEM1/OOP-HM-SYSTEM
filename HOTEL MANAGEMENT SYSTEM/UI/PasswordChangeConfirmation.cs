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
    public partial class PasswordChangeConfirmation : Form
    {
        private ChangePasswordPage _change;
        public PasswordChangeConfirmation(ChangePasswordPage change)
        {
            InitializeComponent();
            _change = change;
        }

        private void PasswordChangeConfirmation_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            _change.Close();
            this.Close();
        }

        private void PasswordChangeConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
