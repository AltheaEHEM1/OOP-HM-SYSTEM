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
    public partial class LogOutPage : Form
    {
        public LogOutPage()
        {
            InitializeComponent();
        }

        private void LogOutPage_Load(object sender, EventArgs e)
        {

        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        */

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
