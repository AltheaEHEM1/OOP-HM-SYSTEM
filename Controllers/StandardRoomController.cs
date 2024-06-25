using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class StandardRoomController
    {
        // Method to add a standard room
        public bool AddStandardRoom(StandardRoom standardRoom)
        {
            try
            {
                // Add the standard room to the database
                using (var context = new DataContext())
                {
                    context.Rooms.Add(standardRoom);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }

        // Method to read or display all the standard rooms
        public List<StandardRoom> GetStandardRooms()
        {
            try
            {
                // Create instance of DataContext
                using (var context = new DataContext())
                {
                    // Assign list of standard rooms where IsDeleted column is false to variable
                    var standardRooms = context.Rooms
                        .OfType<StandardRoom>()
                        .Where(sr => sr.IsDeleted == false)
                        .ToList();

                    // Return all standard rooms
                    return standardRooms;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return null;
            }
        }

        // Method to edit standard room
        public bool EditStandardRoom(int? roomNumber = null, string roomStatus = null, double? roomPrice = null, int? occupancyLimit = null, string bedType = null, string bathroomInclusion = null)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the standard room exists
                    var standardRoom = context.Rooms
                        .OfType<StandardRoom>()
                        .FirstOrDefault(sr => sr.RoomNumber == roomNumber);

                    if (standardRoom == null || standardRoom.IsDeleted)
                    {
                        return false;
                    }

                    // Update the properties if they have new values
                    if (roomStatus != null) standardRoom.RoomStatus = roomStatus;
                    if (roomPrice.HasValue) standardRoom.RoomPrice = roomPrice.Value;
                    if (occupancyLimit.HasValue) standardRoom.OccupancyLimit = occupancyLimit.Value;
                    if (bedType != null) standardRoom.BedType = bedType;
                    if (bathroomInclusion != null) standardRoom.BathroomInclusion = bathroomInclusion;

                    // Update the standard room record in the database
                    context.Rooms.Update(standardRoom);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }

        // Method to delete standard room
        public bool DeleteStandardRoom(int roomId)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Check if the room id exists
                    var standardRoom = context.Rooms
                        .OfType<StandardRoom>()
                        .FirstOrDefault(sr => sr.RoomId == roomId);

                    if (standardRoom == null)
                    {
                        return false;
                    }

                    // Soft delete the room from the database
                    standardRoom.IsDeleted = true;
                    context.Rooms.Update(standardRoom); // Update the record
                    context.SaveChanges(); // Save changes
                    return true;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }

        // Handle exceptions with error message
        private void HandleException(Exception ex)
        {
            var errorMessage = new StringBuilder();
            errorMessage.AppendLine($"Message: {ex.Message}");
            errorMessage.AppendLine($"Source: {ex.Source}");
            errorMessage.AppendLine($"Stack Trace: {ex.StackTrace}");

            var inner = ex.InnerException;
            while (inner != null)
            {
                errorMessage.AppendLine("---- Inner Exception ----");
                errorMessage.AppendLine($"Message: {inner.Message}");
                errorMessage.AppendLine($"Source: {inner.Source}");
                errorMessage.AppendLine($"Stack Trace: {inner.StackTrace}");
                inner = inner.InnerException;
            }

            MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
