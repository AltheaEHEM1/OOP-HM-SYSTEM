using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System.Text;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class UserController
    {
        // Static field to store the employee number
        private static string _storedEmployeeNumber;

        // Create account
        public bool CreateAccount(string employeeNumber, string fullName, string birthdate, string password)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Generate salt and hash the password
                    string salt = PasswordHasher.GenerateSalt();
                    string saltedPassword = PasswordHasher.HashPassword(password, salt);
                    string jobposition = "Receptionist";
                    string schedule = "Unknown";

                    // Load the default profile picture from resources
                    byte[] defaultProfilePicture = ImageToByteArray(Properties.Resources.defaultprofilepicture);

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
            }
            catch (Exception ex)
            {
                var errorMessage = new StringBuilder();
                errorMessage.AppendLine($"Message: {ex.Message}");
                errorMessage.AppendLine($"Source: {ex.Source}");
                errorMessage.AppendLine($"Stack Trace: {ex.StackTrace}");

                var inner = ex.InnerException;
                while (inner != null)
                {
                    errorMessage.AppendLine("---- Inner Exception ----");
                    errorMessage.AppendLine($"Message: {inner.Message}");
                    errorMessage.AppendLine($"Source: {inner.Source}");
                    errorMessage.AppendLine($"Stack Trace: {inner.StackTrace}");
                    inner = inner.InnerException;
                }

                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to convert an Image to a byte array
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        // Login LoginPage.cs
        public bool LoginAccount(string employeeNumber, string password)
        {
            using (var context = new DataContext())
            {
                // Retrieve the user from the database
                var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == employeeNumber);
                if (user == null)
                {
                    return false;
                }

                // Verify the password
                return PasswordHasher.VerifyPassword(password, user.Salt, user.SaltedPassword);
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

        // Get User Name
        public string GetEmployeeName(string employeeNumber)
        {
            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == employeeNumber);
                return user?.EmployeeName;
            }
        }

        // Logout Form1.cs
        public void LogoutAccount()
        {
            // Implement logout logic if necessary (e.g., clear session, tokens, etc.)
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
