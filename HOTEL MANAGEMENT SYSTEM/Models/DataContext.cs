using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class DataContext : DbContext
    {


        // create the tables for the database
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StandardRoom> StandardRooms { get; set; }
        public DbSet<DeluxeRoom> DeluxeRooms { get; set; }
        public DbSet<Suite> Suites { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = HotelManagement.db"); //connection string and to use sqlite
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasDiscriminator<string>("RoomType")
                .HasValue<StandardRoom>("StandardRoom")
                .HasValue<DeluxeRoom>("DeluxeRoom")
                .HasValue<Suite>("Suite");

            base.OnModelCreating(modelBuilder);
        }
    }
}
