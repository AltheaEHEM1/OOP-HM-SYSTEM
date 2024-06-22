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
        private Form _parentForm;
        private System.Timers.Timer timer;

        public SavedChangesConfirmation(Form form)
        {
            InitializeComponent();
            InitializeTimer();
            _parentForm = form;
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void SavedChangesConfirmation_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Show();
            _parentForm.Hide();
            this.Hide();
        }

        private void SavedChangesConfirmation_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        
        private void Timer_Elapsed(object sender, EventArgs e)
        {
            timer.Stop();
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.Hide()));
            }
            else
            {
                this.Hide();
            }

            _parentForm.Hide();
        }
    }
}
