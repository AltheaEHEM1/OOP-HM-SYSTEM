using System.ComponentModel.DataAnnotations;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class User
    {
        [Key] // indication that this is primary key
        public string EmployeeNumber { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string JobPosition { get; set; }
        public string Email { get; set; }
        public string Schedule { get; set; }

    }
}