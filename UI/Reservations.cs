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
    public partial class Reservations : UserControl
    {

        private Booking booking = new Booking();

        public Reservations()
        {
            InitializeComponent();

        }


        private void ModifyBttn_Click(object sender, EventArgs e)
        {
            ModifyPage modifyPage = new ModifyPage();
            modifyPage.Show(); // Use ShowDialog() if you want it as a modal dialog


        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            TermsandCondition TCPage = new TermsandCondition();
            TCPage.Show(); // Use ShowDialog() if you want it as a modal dialog
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ReservationsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            try
            {

                LoadUpcomingBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /*
            ReservationsTable.Rows.Add("1000", "Shanella Amara Cagulang", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("1", "Maria Nadine Aureus Borja", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("1002", "Darben Lamonte", "Deluxe Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("2", "Althea Amor Asis", "Suites", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("13", "Miyuki Mharie Parocha", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("10", "Maria Nadine Aureus Borja", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("5", "Darben Lamonte", "Deluxe Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("27", "Maria Nadine Aureus Borja", "Standard Room", "12.31.24", "12.25.24");
            **/
        }


        // Load booking data from the database
        private void LoadUpcomingBookings()
        {
            try
            {
                // load booking data from the database if the booking is not cancelled and the checkin date is greater than to the current time
                using (var context = new DataContext())
                {
                    var currentDateTime = DateTime.Now;

                    var bookings = context.Bookings
                        .Where(b => b.CheckInDate > currentDateTime && !b.IsCancelled)
                        .ToList();

                    foreach (var booking in bookings)
                    {
                        // get the booked room to get room number and room type
                        var room = context.Rooms.Find(booking.RoomId);

                        // get the guest name
                        var guest = context.Guests.Find(booking.GuestId);

                        // create a variable that will hold the full name of the guest
                        string guestName = guest.FirstName + " " + guest.LastName;

                        if (room != null)
                        {
                            ReservationGridView.Rows.Add(
                                booking.BookingId
                                , booking.RoomId
                                , booking.GuestId
                                , room.RoomNumber
                                , guestName
                                , "Standard Room"
                                , booking.NumberOfGuest
                                // room.RoomType,
                                , booking.CheckInDate
                                , booking.CheckOutDate
                                , booking.BookingDate
                                , booking.IsCancelled
                            );
                        }
                    }
                }


            }
            catch (Exception ex)
            {

            }
        }

        private void ReservationEditBttn_Click(object sender, EventArgs e)
        {
            ModifyPage callModifyPage = new ModifyPage();
            callModifyPage.ShowDialog();
        }

        private void ReservationCancelBttn_Click(object sender, EventArgs e)
        {
            TermsandCondition callTermsandCondition = new TermsandCondition();
            callTermsandCondition.ShowDialog();
        }

        private void ReservationCalendar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
