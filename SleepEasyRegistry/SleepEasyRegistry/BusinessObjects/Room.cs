using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepEasyRegistry.BusinessObjects
{
    public class Room
    {
        public int RoomNum { get; set; }
        public string RoomDesc { get; set; }
        public string RoomType { get; set; }
        public decimal RoomRate { get; set; }

        public Room(int roomNum, string roomDesc, string roomType, decimal roomRate)
        {
            RoomNum = roomNum;
            RoomDesc = roomDesc;
            RoomType = roomType;
            RoomRate = roomRate;
        }
    }
}
