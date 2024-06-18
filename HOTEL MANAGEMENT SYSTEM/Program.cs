using HOTEL_MANAGEMENT_SYSTEM.UI;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Ensure the database is created and schema is applied before starting the application
            using (var context = new Models.DataContext())
            {
                // database schema is created if not exists
                context.Database.EnsureCreated();
                MessageBox.Show("Created Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DatabaseHelper.CreateDatabaseIfNotExists();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());

        }
    }
}        