using System.ComponentModel.DataAnnotations;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public abstract class Room
    {
        // properties or columns of table
        [Key] // indication that this is primary key
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomStatus { get; set; }
        public float RoomPrice { get; set; }

    }
}