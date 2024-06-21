using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class ConfirmDeletion : Form
    {
        public ConfirmDeletion()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmDeletion_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            ConfirmCancellation callConfirmCancellation = new ConfirmCancellation();
            callConfirmCancellation.Show();

            this.Close();

        }
    }
}
