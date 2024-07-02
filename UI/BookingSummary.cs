using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
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
    public partial class BookingSummary : Form
    {
        // variable that will hold the parameters from the previous form
        private int selectedRoomId;
        private Guest guestInfo;
        private Booking newBooking;
        private string roomType;
        private double valueAddedTax = 100.00;
        private double localTax = 50.00;
        private double serviceCharge = 200.00;

        public BookingSummary(int roomId, Guest guest, Booking booking, string roomType)
        {
            InitializeComponent();
            selectedRoomId = roomId;
            guestInfo = guest;
            newBooking = booking;
            this.roomType = roomType;
        }

        private void SRNavback_Click(object sender, EventArgs e)
        {

        }

        private void BookingSummary_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayData()
        {
            try
            {
                // get the selectedRoom to display the price
                using (var context = new DataContext())
                {
                    var selectedRoom = context.Rooms.Find(selectedRoomId);

                    // get and display the roomprice
                    roomPriceLabel.Text = selectedRoom.RoomPrice.ToString();
                }

                // check the room type and assign to roomTypeLabel
                if (roomType.ToLower() == "standard room")
                {
                    // display the room type
                    roomTypeLabel.Text = roomType;
                }
                else if (roomType.ToLower() == "Deluxe Room")
                {
                    // display the room type
                    roomTypeLabel.Text = roomType;
                }
                else if (roomType.ToLower() == "Suite")
                {
                    // display the room type
                    roomTypeLabel.Text = roomType;
                }

                // display the taxes
                VATAmount.Text = valueAddedTax.ToString();
                LTAmount.Text = localTax.ToString();
                SCAmount.Text = serviceCharge.ToString();

                // calculate the total amount
                totalAmountLabel.Text = CalculateTotalAmount().ToString();

                // display the data
                dateCheckin.Text = newBooking.CheckInDate.ToString();
                dateCheckout.Text = newBooking.CheckOutDate.ToString();
                numberOfGuestLabel.Text = newBooking.NumberOfGuest.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to calculate the total amount
        private double CalculateTotalAmount()
        {
            try
            {
                // return the sum
                return valueAddedTax + localTax + serviceCharge;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void CardConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // add the guest record to the database
                GuestController guestController = new GuestController();
                bool guestAdded = guestController.AddGuest(guestInfo);

                if (guestAdded)
                {
                    try
                    {
                        // add the guestid to the booking record
                        newBooking.GuestId = guestInfo.GuestId;

                        // add the booking record to the database
                        BookingController bookingController = new BookingController();
                        bool bookingAdded = bookingController.AddBooking(newBooking);

                        if (bookingAdded)
                        {
                            // show the success message
                            MessageBox.Show("Booking successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // navigate to the next page
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Booking failed. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}