using System.Linq;
using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public class CurrentUser
    {
        public string EmployeeNumber { get; private set; }
        public string EmployeeName { get; private set; }
        public string Birthdate { get; private set; }
        public string JobPosition { get; private set; }
        public string Schedule { get; private set; }

        public void GetCurrentUserDetails(string employeeNumber)
        {
            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.EmployeeNumber == employeeNumber);
                if (user != null)
                {
                    EmployeeNumber = user.EmployeeNumber;
                    EmployeeName = user.EmployeeName;
                    Birthdate = user.Birthdate;
                    JobPosition = user.JobPosition;
                    Schedule = user.Schedule;
                }
            }
        }
    }
}
