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
    public partial class Reservations : UserControl
    {
        private DateTime filterDate;


        private Booking selectedBooking = new Booking();

        public Reservations()
        {
            InitializeComponent();

        }


        private void SearchBar_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void Reservations_Load(object sender, EventArgs e)
        {
            try
            {
                // reset the filter date to the current date
                filterDate = DateTime.Now;

                LoadUpcomingBookings(filterDate); // load bookings
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
        private void LoadUpcomingBookings(DateTime dateToFilter)
        {
            try
            {
                // reset the selected booking
                selectedBooking = null;

                // load booking data from the database if the booking is not cancelled and the checkin date is greater than to the current time
                BookingController bookingController = new BookingController();
                var bookings = bookingController.GetBookingRecords(dateToFilter);

                // clear the gridview
                ReservationGridView.Rows.Clear();

                // display the booking records
                foreach (var booking in bookings)
                {
                    ReservationGridView.Rows.Add(
                        booking.BookingId
                        , booking.RoomId
                        , booking.GuestId
                        , booking.Room.RoomNumber
                        , booking.Guest.FirstName + " " + booking.Guest.LastName
                        , "Standard Room"
                        , booking.NumberOfGuest
                        , booking.CheckInDate
                        , booking.CheckOutDate
                        , booking.BookingDate
                        , booking.IsCancelled
                    );
                }

                /*
                using (var context = new DataContext())
                {
                    var bookings = context.Bookings
                        .Where(b => b.CheckInDate > filterDate && !b.IsCancelled)
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
                */


            }
            catch (Exception ex)
            {

            }
        }

        private void ReservationEditBttn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if there is a selected booking
                if (selectedBooking != null)
                {
                    ModifyPage callModifyPage = new ModifyPage(selectedBooking);
                    callModifyPage.ShowDialog();
                }
                else
                {
                    throw new Exception("Please select a booking to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ReservationCancelBttn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if there is a selected booking
                if (selectedBooking != null)
                {
                    TermsandCondition callTermsandCondition = new TermsandCondition();
                    callTermsandCondition.ShowDialog();
                }
                else
                {
                    throw new Exception("Please select a booking to cancel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ReservationCalendar_ValueChanged(object sender, EventArgs e)
        {
            // assign the value to filterDate
            filterDate = ReservationCalendar.Value;

            // load the data
            LoadUpcomingBookings(filterDate);
        }

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the data of the selected row
                var selectedRow = ReservationGridView.Rows[e.RowIndex];

                // check if the selected row is not null
                if (selectedRow != null)
                {
                    // assign the data to selected booking
                    selectedBooking.BookingId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    selectedBooking.RoomId = Convert.ToInt32(selectedRow.Cells[1].Value);
                    selectedBooking.GuestId = Convert.ToInt32(selectedRow.Cells[2].Value);
                    selectedBooking.Room.RoomNumber = Convert.ToInt32(selectedRow.Cells[3].Value);
                    selectedBooking.Guest.FirstName = selectedRow.Cells[4].Value.ToString();
                    selectedBooking.Room.RoomType = selectedRow.Cells[5].Value.ToString();
                    selectedBooking.NumberOfGuest = Convert.ToInt32(selectedRow.Cells[6].Value);
                    selectedBooking.CheckInDate = Convert.ToDateTime(selectedRow.Cells[7].Value);
                    selectedBooking.CheckOutDate = Convert.ToDateTime(selectedRow.Cells[8].Value);
                    selectedBooking.BookingDate = Convert.ToDateTime(selectedRow.Cells[9].Value);
                    selectedBooking.IsCancelled = Convert.ToBoolean(selectedRow.Cells[10].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
