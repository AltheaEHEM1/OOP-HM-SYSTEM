using HOTEL_MANAGEMENT_SYSTEM.Models;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public static class DatabaseHelper
    {
        private static readonly ExceptionHandling exception = new ExceptionHandling();

        public static void CreateDatabaseIfNotExists()
        {
            try
            {
                string connectionString = GetDatabaseConnectionString();

                using (var context = new DataContext(connectionString))
                {
                    // Ensure database and tables are created
                    context.Database.EnsureCreated();
                    MessageBox.Show("Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                exception.HandleException(ex);
            }
        }

        public static string GetDatabaseConnectionString()
        {
            // Get the current directory where the application is running
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Navigate up to the project's root directory (assumes this file is in bin/{Debug|Release}/{net5.0|netcoreapp3.1})
            string projectRoot = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;

            // Ensure the Database directory exists
            string databaseDirectory = Path.Combine(projectRoot, "Database");
            if (!Directory.Exists(databaseDirectory))
            {
                Directory.CreateDirectory(databaseDirectory);
            }

            // Combine the project root with the Database folder and database file name
            string dbPath = Path.Combine(databaseDirectory, "HotelManagement.db");

            // Set the SQLite connection string
            return $"Data Source={dbPath}";
        }
    }
}
