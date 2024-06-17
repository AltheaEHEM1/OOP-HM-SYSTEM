using System.ComponentModel.DataAnnotations;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class User
    {
        // Necessary for Login
        [Key]
        public string EmployeeNumber { get; set; } 
        public  string EmployeeName { get; set; }
        public  string Email { get; set; } 
        public  string Birthdate { get; set; } 
        public  string PhoneNumber { get; set; }
        public  string Salt { get; set; } 
        public  string SaltedPassword { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        // For profile purposes    
        public string Username { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; } 
        public string MiddleName { get; set; } 
        public string JobPosition { get; set; } 
        public string Schedule { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
