using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HouseFB.House;

namespace HouseFB.Tests
{
    [TestFixture]
    public class HouseFluentBuilderTests
    {

        [Test]
        public void HouseWithPool_Get_ReturnTrue()
        {
            House houseFB = new HouseBuilder().WithSwimmingPool().Build();
            Assert.AreEqual(true, houseFB.HasSwimmingPool);
        }

        [Test]
        public void HouseWithoutPool_Get_ReturnFalse()
        {
            House houseFB = new HouseBuilder().Build();
            Assert.AreEqual(false, houseFB.HasSwimmingPool);
        }

        [TestCase(2)]
        public void HouseWithGarageAndParkingSpots_Get_ReturnTrueAndNoParkingSpots(int noOfParkingSpots)
        {
            House houseFB = new HouseBuilder().SetNoOfParkingSpotsInGarage(noOfParkingSpots).Build();
            Assert.AreEqual(2, houseFB.ParkingSpotsInGarage);
            Assert.AreEqual(true, houseFB.HasGarage);
        }

        [TestCase(0)]
        public void HouseWithoutGarageAndZeroParking_Get_ReturnTrueAndZeroParking(int noOfParkingSpots)
        {
            House houseFB = new HouseBuilder().SetNoOfParkingSpotsInGarage(noOfParkingSpots).Build();
            Assert.AreEqual(0, houseFB.ParkingSpotsInGarage);
            Assert.AreEqual(false, houseFB.HasGarage);
        }

        [TestCase(3)]
        public void NoOfRooms_Get_Return3Rooms(int noOfRooms)
        {
            House houseFB = new HouseBuilder().AddNoOfRooms(noOfRooms).Build();
            Assert.AreEqual(4, houseFB.NoOfRooms);
        }

        [TestCase(9)]
        public void NoOfWindows_Get_Return9Windows(int noOfWindows)
        {
            House houseFB = new HouseBuilder().AddNoOfWindows(noOfWindows).Build();
            Assert.AreEqual(9, houseFB.NoOfWindows);
        }

        [TestCase(2)]
        public void NoOfParkingSpots_Get_Return2ParkingSpots(int noOfParkingSpots)
        {
            House houseFB = new HouseBuilder().SetNoOfParkingSpotsInGarage(noOfParkingSpots).Build();
            Assert.AreEqual(2, houseFB.ParkingSpotsInGarage);
        }

        [TestCase("10641 La Alondra Avenue, Fountain Valley, California 92708")]
        public void StreetAddress_Get_Return_String_StreetAddress(string streetAddress)
        {
            House houseFB = new HouseBuilder().SetStreetAddress(streetAddress).Build();
            Assert.AreEqual("10641 La Alondra Avenue, Fountain Valley, California 92708", houseFB.StreetAddress);
        }

        [TestCase(-3)]
        public void NoOfRooms_IsNegative_Get_ReturnArgException(int noOfRooms)
        {
            Assert.That(() => new HouseBuilder().AddNoOfRooms(noOfRooms).Build(),
                Throws.TypeOf<ArgumentException>()
                .With.Message.EqualTo("Cannot create a house with zero or a negative number of rooms, windows, or parking spots!"));
        }

        [TestCase(-2)]
        public void NoOfWindows_IsNegativeNo_Get_ReturnArgException(int noOfWindows)
        {
            Assert.That(() => new HouseBuilder().AddNoOfRooms(noOfWindows).Build(),
                Throws.TypeOf<ArgumentException>()
                .With.Message.EqualTo("Cannot create a house with zero or a negative number of rooms, windows, or parking spots!"));
        }

        [TestCase(-2)]
        public void NoOfParkingSpots_IsNegativeNo_Get_ReturnArgException(int noOfParkingSpots)
        {
            Assert.That(() => new HouseBuilder().AddNoOfRooms(noOfParkingSpots).Build(),
                Throws.TypeOf<ArgumentException>()
                .With.Message.EqualTo("Cannot create a house with zero or a negative number of rooms, windows, or parking spots!"));
        }

        //[TestCase(0)]
        //public void NoOfParkingSpots_IsZero_Get_ReturnArgException(int noOfParkingSpots)
        //{
        //    Assert.That(() => new HouseBuilder().AddNoOfRooms(noOfParkingSpots).Build(),
        //        Throws.TypeOf<ArgumentException>()
        //        .With.Message.EqualTo("Cannot create a house with zero or a negative number of rooms, windows, or parking spots!"));
        //}
    }
}