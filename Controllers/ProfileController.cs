using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;  // Required for Image
using System.IO;  // Required for MemoryStream
using System.Linq;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class ProfileController
    {
        // Static field to store the employee number
        private static string _storedEmployeeNumber;

        // Method to convert an Image to a byte array
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        // Get User Job Position
        public string GetUserJobPosition(string employeeNumber)
        {
            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == employeeNumber);
                return user?.JobPosition;
            }
        }

        public string GetUserName(string employeeNumber)
        {
            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == employeeNumber);
                return user?.EmployeeName;  // Assuming you meant to get the email here
            }
        }

        // Update user information ProfilePage.cs
        public void EditProfile(User user)
        {
            using (var context = new DataContext())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.EmployeeNumber == user.EmployeeNumber);
                if (existingUser != null)
                {
                    existingUser.EmployeeNumber = user.EmployeeNumber;
                    existingUser.EmployeeName = user.EmployeeName;
                    existingUser.Birthdate = user.Birthdate;
                    existingUser.JobPosition = user.JobPosition;
                    existingUser.Schedule = user.Schedule;
                    existingUser.ProfilePicture = user.ProfilePicture;

                    context.SaveChanges();
                }
            }
        }

        // Store the employee number
        public void StoreEmployee(string employeeNumber)
        {
            _storedEmployeeNumber = employeeNumber;
            var controller = new UserController();
            var name = controller.GetEmployeeName(employeeNumber);  // Assuming this is for validation or another purpose
        }

        // Retrieve the stored employee number
        public string RetrieveStoredEmployeeNumber()
        {
            return _storedEmployeeNumber;
        }
    }
}
