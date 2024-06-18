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

        public List<StandardRoom> StandardRoomsList { get; private set; }


        // method to add standard room
        public void AddStandardRoom(int roomNumber, string roomStatus, float roomPrice, int occupancyLimit, bool hasFreeWifi)
        {
            using (var context = new DataContext())
            {
                // create instance of StandardRoom 
                StandardRoom standardRoom = new StandardRoom();

                // assign values to the properties
                standardRoom.RoomNumber = roomNumber;
                standardRoom.RoomStatus = roomStatus;
                standardRoom.RoomPrice = roomPrice;
                standardRoom.OccupancyLimit = occupancyLimit;
                standardRoom.HasFreeWifi = hasFreeWifi;
                standardRoom.IsDeleted = false;

                // add the user to the database
                context.StandardRooms.Add(standardRoom);
                context.SaveChanges();
            }
        }


        // method to read list of standard room
        public List<StandardRoom> GetStandardRoom()
        {
            using (var context = new DataContext())
            {

                // fetch all data which IsDeleted Column is false
                StandardRoomsList = context.StandardRooms.Where(x => x.IsDeleted == false).ToList();

                // check if the list is empty
                if (StandardRoomsList.Count == 0)
                {
                    // return null if the list is empty
                    return null;
                }
                else
                {
                    // return all standard room
                    return StandardRoomsList;
                }

            }
        }

        // method to edit standard room
        public void EditStandardRoom(int roomId, int roomNumber, string roomStatus, float roomPrice, int occupancyLimit, bool hasFreeWifi)
        {
            using (var context = new DataContext())
            {
                // fetch the standard room record
                StandardRoom standardRoom = context.StandardRooms.Find(roomId);

                try
                {
                    if (standardRoom == null)
                    {
                        throw new Exception("Standard Room is empty.");
                    }
                    
                    // assign values to the properties
                    standardRoom.RoomNumber = roomNumber;
                    standardRoom.RoomStatus = roomStatus;
                    standardRoom.RoomPrice = roomPrice;
                    standardRoom.OccupancyLimit = occupancyLimit;
                    standardRoom.HasFreeWifi = hasFreeWifi;

                    // update the standard room record
                    context.StandardRooms.Update(standardRoom);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // method to delete standard room
        public void DeleteStandardRoom(int roomId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    // fetch the standard room record base on room id
                    StandardRoom standardRoom = context.StandardRooms.Find(roomId);

                    if (standardRoom == null)
                    {
                        throw new Exception("Standard Room does not exist.");
                    }
                    else
                    {
                        // set the IsDeleted column to true
                        standardRoom.IsDeleted = true;

                        // update the standard room record
                        context.StandardRooms.Update(standardRoom);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
