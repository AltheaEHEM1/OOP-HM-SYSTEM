using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System.Text;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class UserController
    {
        // Static field to store the employee number and declare the DataContext
        private static readonly DataContext context = new();
        private static readonly ExceptionHandling eH = new();

        // CreateAccountForm.cs
        public bool CreateUser(string employeeNumber, string fullName, string birthdate, string password)
        {
            try 
            { 
                // Check if the employee number already exists
                if (context.Users.Any(u => u.EmployeeNumber == employeeNumber))
                {
                    MessageBox.Show("The employee number already exists. Please enter a unique employee number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Generate salt and hash the password
                string salt = PasswordHasher.GenerateSalt();
                string saltedPassword = PasswordHasher.HashPassword(password, salt);
                string jobposition = "Admin";
                string schedule = "Unknown";

                // Load the default profile picture from resources
                byte[] defaultProfilePicture = ImageHelper.ImageToByteArray(Properties.Resources.defaultprofilepicture);

                // Create a new user instance
                var user = new User
                {
                    EmployeeNumber = employeeNumber,
                    EmployeeName = fullName,
                    Birthdate = birthdate,
                    Salt = salt,
                    SaltedPassword = saltedPassword,
                    CreatedAt = DateTime.Now,
                    JobPosition = jobposition,
                    Schedule = schedule,
                    ProfilePicture = defaultProfilePicture
                };

                // Add the user to the database
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)  // For detailed error messages
            {
                eH.HandleException(ex);
                return false;
            }
        }

        // LoginPage.cs   
        public bool LoginUser(string employeeNumber, string password)
        {
            try
            {
                // Retrieve the user from the database
                var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == employeeNumber);
                if (user != null && PasswordHasher.VerifyPassword(password, user.Salt, user.SaltedPassword))
                {
                    // Set user information in UserSession
                    UserSession.EmployeeNumber = user.EmployeeNumber;
                    UserSession.EmployeeName = user.EmployeeName;
                    UserSession.JobPosition = user.JobPosition;
                    UserSession.Schedule = user.Schedule;
                    UserSession.ProfilePicture = user.ProfilePicture;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                eH.HandleException(ex);
                return false;
            }
        }

        // Logout Form1.cs
        public void LogoutUser()
        {
            try
            {
                // Clear user session or any related data
                // For example, if you are using a static class to store user info, clear it
                UserSession.EmployeeNumber = null;
                UserSession.EmployeeName = null;
                UserSession.JobPosition = null;
                UserSession.Schedule = null;
                UserSession.ProfilePicture = null;

                // Create a list to store forms that need to be closed
                List<Form> formsToClose = new List<Form>();

                // Add forms to the list that need to be closed
                foreach (Form form in Application.OpenForms)
                {
                    if (form is not LoginPage)
                    {
                        formsToClose.Add(form);
                    }
                }

                // Close forms in the separate list
                foreach (Form form in formsToClose)
                {
                    form.Close();
                }
            }
            catch (Exception ex)
            {
                eH.HandleException(ex);
            }
        }

        // Update user information ProfilePage.cs
        // no birthdate yet
        public bool EditUser(User user)
        {
            try
            {
                /*
                    EmployeeNumber = employeeNumber,
                    EmployeeName = fullName,
                    Birthdate = birthdate,
                    Salt = salt,
                    SaltedPassword = saltedPassword,
                    CreatedAt = DateTime.Now,
                    JobPosition = jobposition,
                    Schedule = schedule,
                    ProfilePicture = defaultProfilePicture
                */


                var context = new DataContext();
                MessageBox.Show("before exisintg");
                var existingUser = context.Users.FirstOrDefault(u => u.EmployeeNumber == user.EmployeeNumber);
                MessageBox.Show("after exisintg");
                if (existingUser != null)
                {
                    MessageBox.Show("uSER IS FOUND");
                    existingUser.EmployeeNumber = user.EmployeeNumber;
                    existingUser.EmployeeName = user.EmployeeName;
                    existingUser.Birthdate = user.Birthdate;
                    existingUser.Salt = existingUser.Salt;
                    existingUser.SaltedPassword = existingUser.SaltedPassword;
                    existingUser.CreatedAt = existingUser.CreatedAt;
                    existingUser.JobPosition = user.JobPosition;
                    existingUser.Schedule = user.Schedule;
                    existingUser.ProfilePicture = user.ProfilePicture;

                    context.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("uSER IS NOT FOUND");
                    return false;
                }
            }
            catch (Exception ex)
            {
                eH.HandleException(ex);
                return false;
            }
        }
    }
}
