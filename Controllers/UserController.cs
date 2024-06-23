using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class UserController
    {
        private static readonly ExceptionHandling exception = new();

        public bool CreateUser(string employeeNumber, string fullName, string birthdate, string password)
        {
            try
            {
                using (var context = new DataContext(DatabaseHelper.GetDatabaseConnectionString()))
                {
                    if (context.Users.Any(u => u.EmployeeNumber == employeeNumber))
                    {
                        Validation.ShowErrorMessage("The employee number already exists. Please enter a unique employee number.");
                        return false;
                    }

                    string salt = PasswordHasher.GenerateSalt();
                    string saltedPassword = PasswordHasher.HashPassword(password, salt);
                    string jobposition = "Admin";
                    string schedule = "Unknown";

                    byte[] defaultProfilePicture = ImageHelper.ImageToByteArray(Properties.Resources.defaultprofilepicture);

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

                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
                return false;
            }
        }

        public int LoginUser(string employeeNumber, string password)
        {
            try
            {
                using (var context = new DataContext(DatabaseHelper.GetDatabaseConnectionString()))
                {
                    var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == employeeNumber);
                    if (user == null) return 2; // User not found
                    if (!PasswordHasher.VerifyPassword(password, user.Salt, user.SaltedPassword)) return 3; // Incorrect password

                    UserSession.EmployeeNumber = user.EmployeeNumber;
                    UserSession.EmployeeName = user.EmployeeName;
                    UserSession.Birthdate = user.Birthdate;
                    UserSession.JobPosition = user.JobPosition;
                    UserSession.Schedule = user.Schedule;
                    UserSession.ProfilePicture = user.ProfilePicture;
                    return 1;
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
                return 0;
            }
        }

        public bool EditUser()
        {
            try
            {
                using (var context = new DataContext(DatabaseHelper.GetDatabaseConnectionString()))
                {
                    var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == UserSession.EmployeeNumber);
                    if (user == null)
                    {
                        Validation.ShowErrorMessage("User not found.");
                        return false;
                    }

                    user.EmployeeNumber = UserSession.EmployeeNumber;
                    user.EmployeeName = UserSession.EmployeeName;
                    user.Birthdate = UserSession.Birthdate;
                    user.Salt = user.Salt;
                    user.SaltedPassword = user.SaltedPassword;
                    user.CreatedAt = user.CreatedAt;
                    user.JobPosition = UserSession.JobPosition;
                    user.Schedule = UserSession.Schedule;
                    user.ProfilePicture = UserSession.ProfilePicture;

                    context.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
                return false;
            }
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            try
            {
                using (var context = new DataContext(DatabaseHelper.GetDatabaseConnectionString()))
                {
                    var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == UserSession.EmployeeNumber);
                    if (user == null)
                    {
                        Validation.ShowErrorMessage("User not found.");
                        return false;
                    }

                    if (!PasswordHasher.VerifyPassword(currentPassword, user.Salt, user.SaltedPassword))
                    {
                        Validation.ShowErrorMessage("Current password is incorrect.");
                        return false;
                    }

                    user.EmployeeNumber = UserSession.EmployeeNumber;
                    user.EmployeeName = UserSession.EmployeeName;
                    user.Birthdate = UserSession.Birthdate;
                    user.Salt = PasswordHasher.GenerateSalt();
                    user.SaltedPassword = PasswordHasher.HashPassword(newPassword, user.Salt);
                    user.CreatedAt = user.CreatedAt;
                    user.JobPosition = UserSession.JobPosition;
                    user.Schedule = UserSession.Schedule;
                    user.ProfilePicture = UserSession.ProfilePicture;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
                return false;
            }
        }

        public void LogoutUser()
        {
            try
            {
                UserSession.Clear();

                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form is not LoginPage)
                    {
                        form.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
            }
        }
    }
}
