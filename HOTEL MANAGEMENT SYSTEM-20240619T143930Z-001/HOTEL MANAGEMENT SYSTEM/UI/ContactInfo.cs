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
    public partial class ContactInfo : Form
    {
        public ContactInfo()
        {
            InitializeComponent();
        }

        private void NextNavSummary_Click(object sender, EventArgs e)
        {
            CardPayment cardPayment = new CardPayment();
            cardPayment.Show();

            // Close the parent form
            Form parentForm = this.FindForm();
            parentForm.Hide();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            //SelectRoom selectRoom = new SelectRoom ();
           // selectRoom.Show();

            // Close the parent form
            Form parentForm = this.FindForm();
            parentForm.Hide();
        }
    }
}
