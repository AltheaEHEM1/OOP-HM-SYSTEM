using Microsoft.EntityFrameworkCore;

// DB stored in ...HOTEL MANAGEMENT SYSTEM\bin\Debug\net8.0-windows
// DB name is HotelManagement.db

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class DataContext : DbContext
    {
        // create the tables for the database
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = HotelManagement.db"); //connection string and to use sqlite
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the model here if needed
        }
    }
}
