using System.ComponentModel.DataAnnotations;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Booking
    {
        [Key] // indication that this is primary key
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string BookingDate { get; set; }
        public int NumberOfGuest { get; set; }
        public string BookingStatus { get; set; }
    }
}