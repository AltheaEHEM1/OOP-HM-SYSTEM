using HOTEL_MANAGEMENT_SYSTEM.UI;
using HOTEL_MANAGEMENT_SYSTEM.Utilities;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    internal static class Program
    {
        private static RoomStatusUpdater roomStatusUpdater;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Ensure the database is created
            using (var context = new Models.DataContext())
            {
                context.Database.EnsureCreated();
            }

            // Start the RoomStatusUpdater
            roomStatusUpdater = new RoomStatusUpdater();
            roomStatusUpdater.Start();

            // Start the application
            Application.Run(new LoginPage());

            // Ensure RoomStatusUpdater is stopped when application exits
            Application.ApplicationExit += OnApplicationExit;
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            roomStatusUpdater?.Stop();
        }
    }
}
