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
    public partial class PaymentInfo : Form
    {
        public PaymentInfo()
        {
            InitializeComponent();
        }

        private void Transparentcontainer_Paint(object sender, PaintEventArgs e)
        {
            Transparentcontainer.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, Transparentcontainer.ClientRectangle);
            }
        }

        private void Cashbutton_Click(object sender, EventArgs e)
        {
            CashPayment cashPayment = new CashPayment();
            cashPayment.Show();

            // Hide the LoginPage form
            this.Hide();
        }
    }
}
