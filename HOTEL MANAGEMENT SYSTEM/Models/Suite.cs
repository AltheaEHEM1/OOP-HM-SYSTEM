using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Suite : Room
    {
        public bool HasJacuzzi { get; set; }
        public int NumberOfRooms { get; set; }
    }
}
