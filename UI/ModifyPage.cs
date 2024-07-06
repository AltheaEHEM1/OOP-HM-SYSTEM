using HOTEL_MANAGEMENT_SYSTEM.Models;
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
        // instance of booking to store the booking to edit
        private Booking bookingToEdit = new Booking();


        public ModifyPage(Booking booking)
        {
            InitializeComponent();
            bookingToEdit = booking;
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the ModifyPage form
        }



        private void SaveChangesBttn_Click(object sender, EventArgs e)
        {
            ChangesSaved callChangesSaved = new ChangesSaved();
            callChangesSaved.FormClosed += ChangesSaved_FormClosed;
            callChangesSaved.Show();

            //this.Hide();





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

        private void ChangesSaved_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the ModifyPage form
            this.Close();
        }

        private void ModifyPage_Load(object sender, EventArgs e)
        {
            try
            {
                // display the data from the bookingToEdit instance
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayData()
        {
            try
            {
                // display the data, assign it to their appropriate label
                bookingIdTxt.Text = bookingToEdit.BookingId.ToString();
                roomIdTxt.Text = bookingToEdit.RoomId.ToString();
                guestIdTxt.Text = bookingToEdit.GuestId.ToString();
                emailTxt.Text = bookingToEdit.Guest.Email;
                nameTxt.Text = bookingToEdit.Guest.FirstName;
                addressTxt.Text = bookingToEdit.Guest.HouseAddress + " " + bookingToEdit.Guest.City + " " + bookingToEdit.Guest.Country + " " + bookingToEdit.Guest.ZipCode.ToString();
                phoneTxt.Text = bookingToEdit.Guest.PhoneNumber.ToString();
                roomNumberTxt.Text = bookingToEdit.Room.RoomNumber.ToString();
                roomTypeTxt.Text = bookingToEdit.RoomType;
                noOfOccupantsTxt.Text = bookingToEdit.NumberOfGuest.ToString();
                modePaymentTxt.Text = bookingToEdit.ModeOfPayment;
                CheckInDatePicker.Value = bookingToEdit.CheckInDate;
                CheckOutDatePicker.Value = bookingToEdit.CheckOutDate;
                isCancelledTxt.Text = bookingToEdit.IsCancelled.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}