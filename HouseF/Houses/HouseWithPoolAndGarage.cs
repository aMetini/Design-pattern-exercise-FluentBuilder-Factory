using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class HouseWithPoolAndGarage : House
    {
        public HouseWithPoolAndGarage()
        {
            StreetAddress = "965 Oasis Dr, Torrance, California 90502";
            NoOfRooms = 4;
            NoOfBathrooms = 2;
            NoOfWindows = 9;
            ParkingSpotsInGarage = 2;
            HasSwimmingPool = true;
        }
    }
}
