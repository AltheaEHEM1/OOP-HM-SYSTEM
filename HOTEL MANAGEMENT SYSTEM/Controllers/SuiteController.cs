using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class SuiteController
    {
        // method to add Suite Room
        public void AddSuite(int roomNumber, string roomStatus, float roomPrice, bool hasJacuzzi, int numberOfRooms)
        {
            var suite = new Suite
            {
                RoomNumber = roomNumber,
                RoomStatus = roomStatus,
                RoomPrice = roomPrice,
                HasJacuzzi = hasJacuzzi,
                NumberOfRooms = numberOfRooms
            };

            RoomController roomController = new RoomController();
            roomController.AddRoom(suite);

        }
    }
}
