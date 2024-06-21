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
    public partial class SavedChangesConfirmation : Form
    {
        private EditProfile _profile;
        
        public SavedChangesConfirmation(EditProfile profile)
        {
            InitializeComponent();
            _profile = profile;
        }
        
        private void SavedChangesConfirmation_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            _profile.Close();
            this.Close();
        }
    }
}
