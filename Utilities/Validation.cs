using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    internal class Validation
    {
        public static bool ValidateLogin(string employeeNumber, string password)
        {
            if (string.IsNullOrWhiteSpace(employeeNumber) || string.IsNullOrWhiteSpace(password))
            {
                ShowErrorMessage("All fields must be filled out.");
                return false;
            }

            return true;
        }

        public static bool ValidateChangePassword(string currentPassword, string newPassword, string confirmNewPassword)
        {
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                ShowErrorMessage("All fields must be filled out.");
                return false;
            }

            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[~`!@#$%^&*()_\-+={[}\]|\:;""'<,>.?/]).{8,}$";
            if (!Regex.IsMatch(newPassword, passwordPattern))
            {
                ShowErrorMessage("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.");
                return false;
            }

            if (newPassword != confirmNewPassword)
            {
                ShowErrorMessage("New password and confirm new password do not match.");
                return false;
            }

            if (currentPassword == newPassword)
            {
                ShowErrorMessage("New password must be different from the current password.");
                return false;
            }

            return true;
        }

        public static bool ValidateUserDetails(string EmployeeName, string idNumber, string position, string schedule)
        {
            if (string.IsNullOrWhiteSpace(EmployeeName))
            {
                ShowErrorMessage("Employee name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(idNumber))
            {
                ShowErrorMessage("ID number cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(position))
            {
                ShowErrorMessage("Position cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(schedule))
            {
                ShowErrorMessage("Schedule cannot be empty.");
                return false;
            }
            // Additional validation rules can be added here if needed

            return true;
        }

        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
