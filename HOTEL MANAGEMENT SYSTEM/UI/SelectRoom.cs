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
    public partial class SelectRoom : Form
    {
        private Form1 parentForm;

        public SelectRoom()
        {
            InitializeComponent();
            InitializeParentForm();
        }

        private void InitializeParentForm()
        {
            parentForm = new Form1();  // Create an instance of form1
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SelectRoom_Load(object sender, EventArgs e)
        {

            Booknow booknow = new Booknow(); // Create an instance of Booknow
            parentForm.addUserControl(booknow); // Add Booknow to form1
            parentForm.Show(); 
        }

        private void NextNav_Click(object sender, EventArgs e)
        {
            ContactInfo contactInfo = new ContactInfo();
            contactInfo.Show();
            this.Close();
        }

        private void SRNavback_Click(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);

            // Close the parent form
            Form parentForm = this.FindForm();
            this.Hide();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SRPanelBack_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
