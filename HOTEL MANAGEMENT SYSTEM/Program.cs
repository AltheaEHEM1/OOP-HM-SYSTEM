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
<<<<<<< HEAD

            // Ensure the database is created and schema is applied before starting the application
            using (var context = new Models.DataContext())
            {
                // database schema is created if not exists
                context.Database.EnsureCreated();
            }

            // Start the main form of the application
            Application.Run(new Form1());
=======
            Application.Run(new LoginPage());
>>>>>>> 698f8ee2c87f4891063421bff0fcb6d3da92ed00
        }
    }
}
