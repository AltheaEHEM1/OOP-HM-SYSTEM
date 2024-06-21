using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class StandardRoomController
    {
        // method to add a standard room
        public bool AddStandardRoom(int roomNumber, string roomStatus, double roomPrice, int occupancyLimit, string bedType, string bathroomInclusion)
        {
            try
            {
                // create instance of StandardRoom
                StandardRoom standardRoom = new StandardRoom();

                standardRoom.RoomNumber = roomNumber;
                standardRoom.RoomStatus = roomStatus;
                standardRoom.RoomPrice = roomPrice;
                standardRoom.OccupancyLimit = occupancyLimit;
                standardRoom.BedType = bedType;
                standardRoom.BathroomInclusion = bathroomInclusion;
                standardRoom.IsDeleted = false;

                // add the standard room to the database
                using (var context = new DataContext())
                {
                    context.StandardRooms.Add(standardRoom);
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                HandleException(ex);
                return false;
            }

        }


        // method to read or display all the standard rooms
        public List<StandardRoom> GetStandardRooms()
        {
            try
            {
                // create instance of DataContext
                using (var context = new DataContext())
                {
                    // assign list of standard rooms where IsDeleted column is false to variable
                    var standardRooms = context.StandardRooms.Where(sr => sr.IsDeleted == false).ToList();

                    // return all standard rooms
                    return standardRooms;

                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return null;
            }
        }


        // method to edit standard room
        public bool EditStandardRoom(int? roomNumber = null, string? roomStatus=null, double? roomPrice=null, int? occupancyLimit=null, string? bedType=null, string? bathroomInclusion=null)
        {
            try
            {
                StandardRoom standardRoom = new StandardRoom();

                // check if the standard room exists
                using (var context = new DataContext())
                {
                    standardRoom = context.StandardRooms.FirstOrDefault(sr => sr.RoomNumber == roomNumber);
                    if (standardRoom == null || standardRoom.IsDeleted == true)
                    {
                        return false;
                    }

                    // update the properties if they have new values
                    if (roomNumber.HasValue) standardRoom.RoomNumber = roomNumber.Value;
                    if (roomStatus != null) standardRoom.RoomStatus = roomStatus;
                    if (roomPrice.HasValue) standardRoom.RoomPrice = roomPrice.Value;
                    if (occupancyLimit.HasValue) standardRoom.OccupancyLimit = occupancyLimit.Value;
                    if (bedType != null) standardRoom.BedType = bedType;
                    if (bathroomInclusion != null) standardRoom.BathroomInclusion = bathroomInclusion;

                    // update the standard room record in the database
                    context.StandardRooms.Update(standardRoom);
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


        // method to delete standard room
        public bool DeleteStandardRoom(int roomId)
        {
            try
            {
                using (var context = new DataContext())
                {
                    // create StandardRoom instance
                    StandardRoom standardRoom = new StandardRoom();
                    // checks if room id exists
                    standardRoom = context.StandardRooms.FirstOrDefault(sr => sr.RoomId == roomId);
                    if (standardRoom == null)
                    {
                        return false;
                    }

                    // soft delete the room from the database
                    standardRoom.IsDeleted = true;
                    context.StandardRooms.Update(standardRoom); // update the record
                    context.SaveChanges(); // save changes
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
