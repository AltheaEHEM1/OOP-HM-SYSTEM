using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class RoomController 
    {
        //method to add room
        public void AddRoom(Room room)
        {
            using (var context = new DataContext())
            {
                context.Rooms.Add(room);
                context.SaveChanges();
            }
        }
    }
}
