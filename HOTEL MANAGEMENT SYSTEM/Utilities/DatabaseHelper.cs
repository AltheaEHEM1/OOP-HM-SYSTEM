using HOTEL_MANAGEMENT_SYSTEM.Models;

// DB stored in ...HOTEL MANAGEMENT SYSTEM\bin\Debug\net8.0-windows
// DB name is HotelManagement.db

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public static class DatabaseHelper
    {
        public static void CreateDatabaseIfNotExists()
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Ensure database and tables are created
                    context.Database.EnsureCreated();
                    MessageBox.Show("Created Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
