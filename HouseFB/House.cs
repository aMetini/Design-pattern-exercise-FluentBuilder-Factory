using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{
    public class House
    {
        public int NoOfRooms { get; set; } = 1;

        public int NoOfWindows { get; set; } = 0;

        /// <summary>This field includes the street name and the street number</summary>
        public string StreetAddress { get; set; }

        public bool HasSwimmingPool { get; set; }

        public int ParkingSpotsInGarage { get; set; }

        public bool HasGarage => ParkingSpotsInGarage > 0;

        public static HouseBuilder Builder = new HouseBuilder();

        private House() {}

        private House(int noOfRooms, int noOfWindows, string streeAdress, bool hasSwimmingPool, int parkingSpotsInGarage)
        {
            NoOfRooms = noOfRooms = 1;
            NoOfWindows = noOfWindows;
            StreetAddress = streeAdress;
            HasSwimmingPool = hasSwimmingPool;
            ParkingSpotsInGarage = parkingSpotsInGarage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"This house is located at {StreetAddress}.");
            sb.AppendLine($"It has {NoOfRooms} rooms and {NoOfWindows} windows");
            if (HasSwimmingPool & HasGarage)
            {
                sb.Append($"It is very fancy and has both a swimming pool, and a garage with space for {ParkingSpotsInGarage} car");
                if (ParkingSpotsInGarage > 1)
                {
                    sb.Append("s");
                }
                sb.AppendLine(".");
            }
            else if (HasSwimmingPool)
            {
                sb.AppendLine("It has a nice swimming pool");
            }
            else if (HasGarage)
            {
                sb.AppendLine($"It has a garage with place for {ParkingSpotsInGarage} cars");
            }
            return sb.ToString();
        }

        #region HouseBuilder
        public class HouseBuilder
        {

            private House _house;

            public HouseBuilder()
            {
                _house = new House();
            }

            public HouseBuilder AddNoOfRooms(int noOfRooms)
            {
                _house.NoOfRooms += noOfRooms;
                return this;
            }

            public HouseBuilder AddNoOfWindows(int noOfWindows)
            {
                _house.NoOfWindows += noOfWindows;
                return this;
            }

            public HouseBuilder SetStreetAddress(string streetAddress)
            {
                _house.StreetAddress = streetAddress;
                return this;
            }

            public HouseBuilder WithSwimmingPool()
            {
                _house.HasSwimmingPool = true;
                return this;
            }

            public HouseBuilder SetNoOfParkingSpotsInGarage(int noOfParkingSpots)
            {
                _house.ParkingSpotsInGarage += noOfParkingSpots;
                return this;
            }

            public House Build()
            {
                if (_house.NoOfRooms < 0 || _house.NoOfWindows < 0 || _house.ParkingSpotsInGarage < 0)
                    throw new ArgumentException("Cannot create a house with zero or a negative number of rooms, windows, or parking spots!");
                return _house;
            }

        }
        #endregion
    }
}
