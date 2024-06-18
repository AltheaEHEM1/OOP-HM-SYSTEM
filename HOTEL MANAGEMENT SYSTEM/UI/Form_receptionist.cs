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
    public partial class Form_receptionist : Form
    {
        public Form_receptionist()
        {
            InitializeComponent();
            //Transactions_recep uc = new Transactions_recep();
            //addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelinformreceptionist_usercontrol.Controls.Clear();
            panelinformreceptionist_usercontrol.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel_navigation_transparent_recep_Paint(object sender, PaintEventArgs e)
        {
            panel_navigation_transparent_recep.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) // Transparency
            {
                e.Graphics.FillRectangle(brush, panel_navigation_transparent_recep.ClientRectangle);
            }
        }

        private void Transaction_button_recep_Click(object sender, EventArgs e)
        {
            //Transactions_recep uc = new Transactions_recep();
            //addUserControl(uc);
        }

        private void Booknow_button_recep_Click(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);
        }

        private void Reservation_button_recep_Click(object sender, EventArgs e)
        {
            Reservations uc = new Reservations();
            addUserControl(uc);
        }

        private void Guest_button_recep_Click(object sender, EventArgs e)
        {
            //Guest_recep uc = new Guest_recep();
            //addUserControl(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
