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
    public partial class CardPayment : Form
    {
        public CardPayment()
        {
            InitializeComponent();
        }

        private void CardConfirmPayment_Click(object sender, EventArgs e)
        {
            BookingSummary bookingSummary = new BookingSummary();
            bookingSummary.Show();

            // Close the parent form
            Form parentForm = this.FindForm();
            parentForm.Hide();
        }
    }
}
