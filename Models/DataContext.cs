﻿using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
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
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        // Create the tables for the database
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
