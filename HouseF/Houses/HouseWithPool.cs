using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class HouseWithPool : House
    {
        public HouseWithPool()
        {
            StreetAddress = "975 Cheyenne Street, Costa Mesa, California 92626";
            NoOfRooms = 6;
            NoOfBathrooms = 2;
            NoOfWindows = 12;
            HasSwimmingPool = true;
        }
    }
}
