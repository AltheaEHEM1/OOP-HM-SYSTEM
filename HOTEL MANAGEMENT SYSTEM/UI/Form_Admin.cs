using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            Dashboard_admin uc = new Dashboard_admin();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelforusercontroladmin.Controls.Clear();
            panelforusercontroladmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Naviationpanelinform_admin_Paint(object sender, PaintEventArgs e)
        {
            Naviationpanelinform_admin.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) // Transparency
            {
                e.Graphics.FillRectangle(brush, Naviationpanelinform_admin.ClientRectangle);
            }
        }

        private void Dashboard_button_Click(object sender, EventArgs e)
        {
            Dashboard_admin  uc = new Dashboard_admin();
            addUserControl(uc);
        }

        private void Rooms_Button_Click(object sender, EventArgs e)
        {
            Rooms_admin uc = new Rooms_admin();
            addUserControl(uc);
        }

        private void Transactions_Button_Click(object sender, EventArgs e)
        {
            Transactions_admin uc = new Transactions_admin();
            addUserControl(uc);
        }

        private void Reports_Button_Click(object sender, EventArgs e)
        {
            Reports_admin uc = new Reports_admin();
            addUserControl(uc);
        }
    }
}
