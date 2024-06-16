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
    public partial class DeluxeRoom : Form
    {
        private Form1 parentForm;

        public DeluxeRoom()
        {
            InitializeComponent();
            InitializeParentForm();
        }

        private void InitializeParentForm()
        {
            parentForm = new Form1();  // Create an instance of Form1
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void NextNav_Click(object sender, EventArgs e)
        {
            ContactInfo contactInfo = new ContactInfo();
            contactInfo.Show();
            this.Close();
        }

        private void DeluxeRoom_Load(object sender, EventArgs e)
        {
            Booknow booknow = new Booknow(); // Create an instance of Booknow
            parentForm.addUserControl(booknow); // Add Booknow to Form1
            parentForm.Show(); // Show Form1
        }

        private void DRNavback_Click_1(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);

            // Close the parent form
            Form parentForm = this.FindForm();
            this.Hide();
        }
    }
}
