using HOTEL_MANAGEMENT_SYSTEM.UI;
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
    public partial class ModifyPage : Form
    {

        public ModifyPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EmailAddTxt_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the ModifyPage form
        }



        private void SaveChangesBttn_Click(object sender, EventArgs e)
        {
            ChangesSaved callChangesSaved = new ChangesSaved();
            callChangesSaved.Show();


            //this.Close();





            //Form changesformbg = new Form();
            //try
            //{
            //    using (ChangesSaved savebttn = new ChangesSaved())
            //    {
            //        changesformbg.StartPosition = FormStartPosition.Manual;
            //        changesformbg.FormBorderStyle = FormBorderStyle.None;
            //        changesformbg.Opacity = .70d;
            //        changesformbg.BackColor = Color.Black;
            //        //formbg.WindowState = FormWindowState.Maximized;
            //        changesformbg.TopMost = true;
            //        changesformbg.Location = this.Location;
            //        changesformbg.ShowInTaskbar = false;



            //        savebttn.Owner = changesformbg;
            //        savebttn.ShowDialog();

            //        changesformbg.Dispose();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    changesformbg.Dispose();
            //}



        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BedroomTypeComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifyPage_Load(object sender, EventArgs e)
        {

        }

        private void HeaderTtilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OtherServicesTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailAdLab_Click(object sender, EventArgs e)
        {

        }

        private void headerTxt_Click(object sender, EventArgs e)
        {

        }

        private void EmailAdLab_Click_1(object sender, EventArgs e)
        {

        }

        private void RoomTypeLbl_Click(object sender, EventArgs e)
        {

        }

        private void RoomTypeTxt_Click(object sender, EventArgs e)
        {

        }
    }
}