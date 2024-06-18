using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class User
    {
        // Necessary for Login
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeNumber { get; set; } 
        public string? EmployeeName { get; set; }
        public string? EmailAddress { get; set; } 
        public string? Birthdate { get; set; } 
        public string? PhoneNumber { get; set; }
        public string? Salt { get; set; } 
        public string? SaltedPassword { get; set; }
        public DateTime CreatedAt { get; set; }


        // For profile purposes    
        public string? JobPosition { get; set; } 
        public string? Schedule { get; set; }
        public byte[]? ProfilePicture { get; set; }
    }
}
