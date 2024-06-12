using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;


namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class UserController
    {
        // Register form but no UI
        public void RegisterUser(string employeeNumber, string username, string password, string lastName, string firstName, string middleName, string jobPosition, string email, string schedule)
        {
            using (var context = new DataContext())
            {
                // Generate salt and hash the password
                string salt = PasswordHasher.GenerateSalt();
                string saltedPassword = PasswordHasher.HashPassword(password, salt);

                // Create a new user instance
                var user = new User
                {
                    EmployeeNumber = employeeNumber,
                    Username = username,
                    Salt = salt,
                    SaltedPassword = saltedPassword,
                    LastName = lastName,
                    FirstName = firstName,
                    MiddleName = middleName,
                    JobPosition = jobPosition,
                    Email = email,
                    Schedule = schedule
                };

                // Add the user to the database
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public bool AuthenticateUser(string username, string password)
        {
            using (var context = new DataContext())
            {
                // Retrieve the user from the database
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    return false;
                }

                // Verify the password
                return PasswordHasher.VerifyPassword(password, user.Salt, user.SaltedPassword);
            }
        }
        public void Logout()
        {
            // Implement logout logic if necessary (e.g., clear session, tokens, etc.)
        }

        public void UpdateUser(User user)
        {
            using (var context = new DataContext())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.EmployeeNumber == user.EmployeeNumber);
                if (existingUser != null)
                {
                    existingUser.Username = user.Username;
                    existingUser.LastName = user.LastName;
                    existingUser.FirstName = user.FirstName;
                    existingUser.MiddleName = user.MiddleName;
                    existingUser.JobPosition = user.JobPosition;
                    existingUser.Email = user.Email;
                    existingUser.Schedule = user.Schedule;

                    context.SaveChanges();
                }
            }
        }
    }
}


