using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class StandardHouse : House
    {
        public StandardHouse()
        {
            StreetAddress = "10963 Lindblade Street, Culver City, California 92646";
            NoOfRooms = 4;
            NoOfBathrooms = 2;
            NoOfWindows = 12;
            ParkingSpotsInGarage = 2;
        }
    }
}
