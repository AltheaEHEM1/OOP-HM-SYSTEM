using Guna.UI2.WinForms;
using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Form_Admin : Form
    {
        private ProfilePopUp profilePopUp;

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
            Dashboard_admin uc = new Dashboard_admin();
            addUserControl(uc);
        }

        private void Rooms_Button_Click(object sender, EventArgs e)
        {
            Rooms_admin uc = new Rooms_admin();
            addUserControl(uc);
        }

        private void Transactions_Button_Click(object sender, EventArgs e)
        {
            Transactions uc = new Transactions();
            addUserControl(uc);
        }

        private void Reports_Button_Click(object sender, EventArgs e)
        {
            Reports_admin uc = new Reports_admin();
            addUserControl(uc);
        }

        private void circilephotoprofile_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp();
            profilePopUp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp();
            profilePopUp.Show();
        }

        private void labelemail_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp();
            profilePopUp.Show();
        }

        private void profilegroup_Click(object sender, EventArgs e)
        {
            ProfilePopUp profilePopUp = new ProfilePopUp();
            profilePopUp.Show();
        }

        private void panelforusercontroladmin_Paint(object sender, PaintEventArgs e)
        {
            var getdetails = new UserController();
            var employeeNumber = getdetails.RetrieveStoredEmployeeNumber();

            labelnameprofile.Text = getdetails.GetEmployeeName(employeeNumber);
            labeljobposition.Text = getdetails.GetUserJobPosition(employeeNumber);
        }

        private void Form_admin_Load(object sender, EventArgs e)
        {

        }
    }
}