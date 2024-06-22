using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public static class UserSession
    {
        public static string? EmployeeNumber { get; set; }
        public static string? EmployeeName { get; set; }
        public static string? Birthdate { get; set; }
        public static string? JobPosition { get; set; }
        public static string? Schedule { get; set; }
        public static byte[]? ProfilePicture { get; set; }
    }
}
