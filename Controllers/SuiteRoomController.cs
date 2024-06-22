﻿using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class SuiteRoomController
    {
        // Method to add a suite room
        public bool AddSuiteRoom(int roomNumber, string roomStatus, double roomPrice, int occupancyLimit, int numberOfRooms, string suiteType)
        {
            try
            {
                // Create instance of suite room
                Suite suiteRoom = new Suite
                {
                    // assign the value to the variables
                    RoomNumber = roomNumber,
                    RoomStatus = roomStatus,
                    RoomPrice = roomPrice,
                    OccupancyLimit = occupancyLimit,
                    NumberOfRooms = numberOfRooms,
                    SuiteType = suiteType,
                    IsDeleted = false
                };

                // Add the suite room to the database
                using (var context = new DataContext())
                {
                    context.Rooms.Add(suiteRoom);
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
