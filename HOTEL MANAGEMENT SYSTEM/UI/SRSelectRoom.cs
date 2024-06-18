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
    public partial class SRSelectRoom : Form
    {
        private Form_receptionist parentForm;
        public SRSelectRoom()
        {
            InitializeComponent();
            //InitializeParentForm();
            
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void InitializeParentForm()
        {
            parentForm = new Form_receptionist();  // Create an instance of form1
        }

        private void SRNavback_Click(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);

            // Close the parent form
            Form parentForm = this.FindForm();
            this.Hide();
        }
        /*
        private void SRSelectRoom_Load(object sender, EventArgs e)
        {
            {
                Booknow booknow = new Booknow(); // Create an instance of Booknow
                addUserControl(uc); // Add Booknow to form1
            }
        }
        */

        private void NextNav_Click(object sender, EventArgs e)
        {
            ContactInfo contactInfo = new ContactInfo();
            contactInfo.Show();
            this.Close();
        }
    }
}
