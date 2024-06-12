using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{

    public static class PasswordHasher
    {
        public static string GenerateSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }

        public static string HashPassword(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password + salt);
        }

        public static bool VerifyPassword(string password, string salt, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password + salt, hashedPassword);
        }
    }

}
