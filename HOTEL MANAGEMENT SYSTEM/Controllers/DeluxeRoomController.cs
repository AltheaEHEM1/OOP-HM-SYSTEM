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
        // function to add standard room
        public void AddDeluxeRoom(int roomNumber, string roomStatus, float roomPrice, bool hasMiniBar)
        {
            var deluxeRoom = new DeluxeRoom
            {
                RoomNumber = roomNumber,
                RoomStatus = roomStatus,
                RoomPrice = roomPrice,
                HasMiniBar = hasMiniBar
            };

            RoomController roomController = new RoomController();
            roomController.AddRoom(deluxeRoom);

        }
    }
}
