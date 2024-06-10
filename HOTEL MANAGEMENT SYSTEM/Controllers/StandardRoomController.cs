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
        // function to add standard room
        public void AddStandardRoom(int roomNumber, string roomStatus, float roomPrice, int occupancyLimit)
        {
            var standardRoom = new StandardRoom
            {
                RoomNumber = roomNumber,
                RoomStatus = roomStatus,
                RoomPrice = roomPrice,
                OccupancyLimit = occupancyLimit
            };

            RoomController roomController = new RoomController();
            roomController.AddRoom(standardRoom);

        }
    }
}
