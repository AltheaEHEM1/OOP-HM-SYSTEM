using System;
using System.Windows.Forms;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using HOTEL_MANAGEMENT_SYSTEM.UI;

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

            // Ensure the database is created if it doesn't exist
            DatabaseHelper.CreateDatabaseIfNotExists();

            // Run the application with the login page
            Application.Run(new LoginPage());
        }
    }
}
