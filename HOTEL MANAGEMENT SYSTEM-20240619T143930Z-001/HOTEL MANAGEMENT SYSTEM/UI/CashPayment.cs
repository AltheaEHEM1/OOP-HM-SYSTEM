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
    public partial class CashPayment : Form
    {
        public CashPayment()
        {
            InitializeComponent();
        }

        private void transparentbg_Paint(object sender, PaintEventArgs e)
        {
            transparentbg.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, transparentbg.ClientRectangle);
            }
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            PaymentInfo paymentInfo = new PaymentInfo();
            paymentInfo.Show();

            // Hide the LoginPage form
            this.Hide();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            successmessagebk Successmessagebk = new successmessagebk();
            Successmessagebk.Show();
        }
    }
}
