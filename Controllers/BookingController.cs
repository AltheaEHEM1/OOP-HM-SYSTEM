using HOTEL_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class BookingController
    {
        public List<Booking> BookingRecords { get; private set; }


        // method to add booking record
        public bool AddBooking(int roomId, int guestId, string checkInDate, string checkoutDate, string bookingDate, int numberOfGuest, string bookingStatus)
        {
            // create instance of Booking
            Booking booking = new Booking();

            //assign the values to the properties
            booking.RoomId = roomId;
            booking.GuestId = guestId;
            booking.CheckInDate = checkInDate;
            booking.CheckOutDate = checkoutDate;
            booking.BookingDate = bookingDate;
            booking.NumberOfGuest = numberOfGuest;
            booking.BookingStatus = bookingStatus;

            // add the booking record to the database
            using (var context = new DataContext())
            {
                context.Bookings.Add(booking);
                context.SaveChanges();
            }

            return true;

        }


        // method to read or display all the booking records
        public List<Booking> GetBookingRecords()
        {
            // create instance of DataContext
            using (var context = new DataContext())
            {
                // assign list of bookings to variables
                BookingRecords = context.Bookings.ToList();

                // return all booking records
                return BookingRecords;

            }
        }

        // method to update booking record
        // Method to update booking record
        public bool UpdateBookingRecord(int bookingId, int roomId, int guestId, string checkInDate, string checkoutDate, string bookingDate, int numberOfGuest, string bookingStatus)
        {
            using (var context = new DataContext())
            {
                // Retrieve the booking record by ID
                var booking = context.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
                if (booking == null)
                {
                    return false;
                }

                // Update the properties if they have new values
                //if (roomId.HasValue) booking.RoomId = roomId.Value;
                //if (guestId.HasValue) booking.GuestId = guestId.Value;
                //if (checkInDate != null) booking.CheckInDate = checkInDate;
                //if (checkoutDate != null) booking.CheckOutDate = checkoutDate;
                //if (bookingDate != null) booking.BookingDate = bookingDate;
                //if (numberOfGuest.HasValue) booking.NumberOfGuest = numberOfGuest.Value;
                //if (bookingStatus != null) booking.BookingStatus = bookingStatus;

                // Mark the entity as modified
                context.Entry(booking).State = EntityState.Modified;

                // Save changes to the database
                context.SaveChanges();

                return true;
            }

        }

        // method to delete booking record
        public void DeleteBookingRecord(int bookingId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    // Retrieve the booking record by ID
                    var booking = context.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
                    if (booking == null)
                    {
                        throw new Exception("Booking not found");
                    }

                    // Remove the booking record
                    context.Bookings.Remove(booking);

                    // Save changes to the database
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"{ex}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
