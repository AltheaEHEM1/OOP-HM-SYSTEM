using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOTEL_MANAGEMENT_SYSTEM.Models;

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
            try
            {
                // create instance of Guest to store the information from text box
                Guest guest = new Guest();

                guest.LastName = lastNameText.Text;
                guest.FirstName = firstNameText.Text;
                guest.DateOfBirth = Convert.ToDateTime(birthdayText.Text);
                guest.PhoneNumber = Convert.ToInt32(phoneNumText.Text);
                guest.Email = emailAddressText.Text;
                guest.City = cityText.Text;
                guest.Country = countryText.Text;
                guest.HouseAddress = houseAddressText.Text;
                guest.ZipCode = Convert.ToInt32(zipcodeText.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void ContactInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
