using System.ComponentModel.DataAnnotations;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class User
    {
        [Key]
        public string EmployeeNumber { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string SaltedPassword { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string JobPosition { get; set; }
        public string Email { get; set; }
        public string Schedule { get; set; }
    }
}
