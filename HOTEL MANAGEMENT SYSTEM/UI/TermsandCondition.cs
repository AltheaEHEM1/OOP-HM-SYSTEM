using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class TermsandCondition : Form
    {
        public TermsandCondition()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TandCText1_Click(object sender, EventArgs e)
        {

        }

        private void TandCText2_Click(object sender, EventArgs e)
        {

        }

        private void CancellationConfirmBttn_Click(object sender, EventArgs e)
        {
             ConfirmDeletion calldeleteform = new ConfirmDeletion();
            calldeleteform.Show();

            //this.Close();


            //Form deletebg = new Form();
            // try
            //{
            //    using (ConfirmDeletion callformDelete = new ConfirmDeletion())
            //    {
            //        deletebg.StartPosition = FormStartPosition.Manual;
            //        deletebg.FormBorderStyle = FormBorderStyle.None;
            //        deletebg.Opacity = .70d;
            //        deletebg.BackColor = Color.Black;
            //        //formbg.WindowState = FormWindowState.Maximized;
            //        deletebg.TopMost = true;
            //        deletebg.Location = this.Location;
            //        deletebg.ShowInTaskbar = false;



            //        callformDelete.Owner = deletebg;
            //        callformDelete.ShowDialog();

            //        deletebg.Dispose();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    deletebg.Dispose();
            //}

            //Form confirmCancellationbg = new Form();
            //confirmCancellationbg.StartPosition = FormStartPosition.CenterScreen;
            //confirmCancellationbg.Opacity = .50d;
            //confirmCancellationbg.BackColor = Color.White;
            //confirmCancellationbg.Size = this.Size;
            //confirmCancellationbg.ShowInTaskbar = false;
            //confirmCancellationbg.Show();
            //confirmCancellationbg.Owner = this;

            ////confirmCancellationbg.ShowDialog();
            //confirmCancellationbg.Dispose();
        }

        private void TCBackBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
