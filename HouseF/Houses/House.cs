using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class House
    {
        public int NoOfRooms { get; set; } = 1;

        public int NoOfWindows { get; set; } = 0;
        public int NoOfBathrooms { get; set; } = 0;

        /// <summary>This field includes the street name and the street number</summary>
        public string StreetAddress { get; set; }

        public bool HasSwimmingPool { get; set; }

        public bool HasTennisCourt { get; set; }
        public bool HasOceanView { get; set; }
        public bool HasMountainView { get; set; }
        public bool HasMarbleFloors { get; set; }

        public int ParkingSpotsInGarage { get; set; }

        public bool HasGarage => ParkingSpotsInGarage > 0;
        public static HouseFactory Factory = new HouseFactory();

        public House() {}

        public House(int noOfRooms, int noOfWindows, int noOfBathrooms, string streeAdress, bool hasSwimmingPool, int parkingSpotsInGarage,
                bool hasTennisCourt, bool hasOceanView, bool hasMountainView, bool hasMarbleFloors)
        {
            NoOfRooms = noOfRooms;
            NoOfWindows = noOfWindows;
            NoOfBathrooms = noOfBathrooms;
            StreetAddress = streeAdress;
            HasSwimmingPool = hasSwimmingPool;
            HasTennisCourt = hasTennisCourt;
            HasOceanView = hasOceanView;
            HasMountainView = hasMountainView;
            HasMarbleFloors = hasMarbleFloors;
            ParkingSpotsInGarage = parkingSpotsInGarage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"This house is located at {StreetAddress}.");
            sb.AppendLine($"It has {NoOfRooms} rooms, {NoOfBathrooms} bathrooms and {NoOfWindows} windows.");


            if (hasAnyDeluxeExtras())
            {
                sb.AppendLine($"It is a deluxe house that has both a swimming pool and a garage with space for {ParkingSpotsInGarage} cars and: ");
                sb.AppendLine();
                if (HasTennisCourt)
                    sb.AppendLine("- a tennis court");
                if (HasOceanView)
                    sb.AppendLine("- an ocean view");
                if (HasMountainView)
                    sb.AppendLine("- a mountain view");
                if (HasMarbleFloors)
                    sb.AppendLine("- marble floors");
            }

            else if (HasSwimmingPool & HasGarage)
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
                sb.AppendLine("It has a nice swimming pool.");
            }
            else if (HasGarage)
            {
                sb.AppendLine($"It has a garage with space for {ParkingSpotsInGarage} cars.");
            }
            
            return sb.ToString();
        }

        private bool hasAnyDeluxeExtras()
        {
            return HasTennisCourt || HasOceanView || HasMountainView || HasMarbleFloors;
        }
    }
}
