using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class DeluxeRoomController
    {
        public List<DeluxeRoom> DeluxeRoomList { get; private set; }


        // method to add deluxe room
        public void AddDeluxeRoom(int roomNumber, string roomStatus, float roomPrice, int occupancyLimit, bool hasMiniBar)
        {
            using (var context = new DataContext())
            {
                // create instance of StandardRoom 
                DeluxeRoom deluxeRoom = new DeluxeRoom();

                // assign values to the properties
                deluxeRoom.RoomNumber = roomNumber;
                deluxeRoom.RoomStatus = roomStatus;
                deluxeRoom.RoomPrice = roomPrice;
                deluxeRoom.OccupancyLimit = occupancyLimit;
                deluxeRoom.HasMiniBar = hasMiniBar;
                deluxeRoom.IsDeleted = false;

                // add the room to the database
                context.DeluxeRooms.Add(deluxeRoom);
                context.SaveChanges();
            }
        }


        // method to read list of deluxe room
        public List<DeluxeRoom> GetDeluxeRooms()
        {
            using (var context = new DataContext())
            {

                // fetch all data which IsDeleted Column is false
                DeluxeRoomList = context.DeluxeRooms.Where(x => x.IsDeleted == false).ToList();

                // check if the list is empty
                if (DeluxeRoomList.Count == 0)
                {
                    // return null if the list is empty
                    return null;
                }
                else
                {
                    // return all standard room
                    return DeluxeRoomList;
                }

            }
        }

        // method to edit deluxe room
        public void EditDeluxeRoom(int roomId, int roomNumber, string roomStatus, float roomPrice, int occupancyLimit, bool hasMiniBar)
        {
            using (var context = new DataContext())
            {
                // fetch the deluxe room record
                DeluxeRoom deluxeRoom = context.DeluxeRooms.Find(roomId);

                try
                {
                    if (deluxeRoom == null)
                    {
                        throw new Exception("Standard Room is empty.");
                    }

                    // assign values to the properties
                    deluxeRoom.RoomNumber = roomNumber;
                    deluxeRoom.RoomStatus = roomStatus;
                    deluxeRoom.RoomPrice = roomPrice;
                    deluxeRoom.OccupancyLimit = occupancyLimit;
                    deluxeRoom.HasMiniBar = hasMiniBar;

                    // update the deluxe room record
                    context.DeluxeRooms.Update(deluxeRoom);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // method to delete deluxe room
        public void DeleteDeluxeRoom(int roomId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    // fetch the deluxe room record base on room id
                    DeluxeRoom deluxeRoom = context.DeluxeRooms.Find(roomId);

                    if (deluxeRoom == null)
                    {
                        throw new Exception("Deluxe Room does not exist.");
                    }
                    else
                    {
                        // set the IsDeleted column to true
                        deluxeRoom.IsDeleted = true;

                        // update the deluxe room record
                        context.DeluxeRooms.Update(deluxeRoom);
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
