using HouseF.Houses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HouseF.Tests
{
    [TestFixture]
    public class HouseFactoryTests
    {
        private HouseFactory _factory;

        [SetUp]
        public void SetUp()
        {
            _factory = new HouseFactory();
        }

        [Test]
        public void CreateHouse_Get_CorrectHouseType()
        {
            // Arrange
            string houseTypeName = "belairdeluxehouse";
            
            // Act
            var calculatedResult = _factory.CreateHouse(houseTypeName);

            // Assert
            Assert.IsInstanceOf<BelAirDeluxeHouse>(calculatedResult);
            Assert.That(calculatedResult.HasMarbleFloors, Is.EqualTo(true));
            Assert.That(calculatedResult.HasTennisCourt, Is.EqualTo(true));
            Assert.That(calculatedResult.HasSwimmingPool, Is.EqualTo(true));
            Assert.That(calculatedResult.HasMountainView, Is.EqualTo(true));
            Assert.That(calculatedResult.HasOceanView, Is.EqualTo(true));
            Assert.That(calculatedResult.HasGarage, Is.EqualTo(true));
            Assert.That(calculatedResult.NoOfRooms, Is.EqualTo(12));
            Assert.That(calculatedResult.NoOfWindows, Is.EqualTo(28));
            Assert.That(calculatedResult.NoOfBathrooms, Is.EqualTo(10));
            Assert.That(calculatedResult.ParkingSpotsInGarage, Is.EqualTo(12));
        }

        [Test]
        public void CreateHouse_GivenTinyHouse_ReturnsCorrectHouseType()
        {
            // Arrange
            string houseTypeName = "tinyhouse";

            // Act
            var calculatedResult = _factory.CreateHouse(houseTypeName);

            // Assert
            Assert.IsInstanceOf<TinyHouse>(calculatedResult);
            Assert.That(calculatedResult.HasMarbleFloors, Is.EqualTo(false));
            Assert.That(calculatedResult.HasTennisCourt, Is.EqualTo(false));
            Assert.That(calculatedResult.HasSwimmingPool, Is.EqualTo(false));
            Assert.That(calculatedResult.HasMountainView, Is.EqualTo(false));
            Assert.That(calculatedResult.HasOceanView, Is.EqualTo(false));
            Assert.That(calculatedResult.HasGarage, Is.EqualTo(false));
            Assert.That(calculatedResult.NoOfRooms, Is.EqualTo(3));
            Assert.That(calculatedResult.NoOfBathrooms, Is.EqualTo(1));
            Assert.That(calculatedResult.NoOfWindows, Is.EqualTo(7));
        }

        [Test]
        public void CreateHouse_GivenHouseWithPool_ReturnCorrectHouseType()
        {
            // Arrange
            string houseTypeName = "housewithpool";

            // Act
            var calculatedResult = _factory.CreateHouse(houseTypeName);

            // Assert
            Assert.IsInstanceOf<HouseWithPool>(calculatedResult);
            Assert.That(calculatedResult.HasSwimmingPool, Is.EqualTo(true));
            Assert.That(calculatedResult.HasGarage, Is.EqualTo(false));
            Assert.That(calculatedResult.NoOfRooms, Is.EqualTo(6));
            Assert.That(calculatedResult.NoOfBathrooms, Is.EqualTo(2));
            Assert.That(calculatedResult.NoOfWindows, Is.EqualTo(12));
        }

        [Test]
        public void CreateHouse_GivenHouseWithPoolAndGarage_ReturnCorrectHouseType()
        {
            // Arrange
            string houseTypeName = "housewithpoolandgarage";

            // Act
            var calculatedResult = _factory.CreateHouse(houseTypeName);

            // Assert
            Assert.IsInstanceOf<HouseWithPoolAndGarage>(calculatedResult);
            Assert.That(calculatedResult.HasSwimmingPool, Is.EqualTo(true));
            Assert.That(calculatedResult.HasGarage, Is.EqualTo(true));
            Assert.That(calculatedResult.NoOfRooms, Is.EqualTo(4));
            Assert.That(calculatedResult.NoOfBathrooms, Is.EqualTo(2));
            Assert.That(calculatedResult.NoOfWindows, Is.EqualTo(9));
            Assert.That(calculatedResult.ParkingSpotsInGarage, Is.EqualTo(2));
        }

        [Test]
        public void CreateHouse_GivenHouseWithGarage_ReturnCorrectHouseType()
        {
            // Arrange
            string houseTypeName = "standardhouse";

            // Act
            var calculatedResult = _factory.CreateHouse(houseTypeName);

            // Assert
            Assert.IsInstanceOf<StandardHouse>(calculatedResult);
            Assert.That(calculatedResult.HasGarage, Is.EqualTo(true));
            Assert.That(calculatedResult.NoOfRooms, Is.EqualTo(4));
            Assert.That(calculatedResult.NoOfBathrooms, Is.EqualTo(2));
            Assert.That(calculatedResult.NoOfWindows, Is.EqualTo(12));
            Assert.That(calculatedResult.ParkingSpotsInGarage, Is.EqualTo(2));
            Assert.That(calculatedResult.HasSwimmingPool, Is.EqualTo(false));
        }

        //[Test]
        //public void CreateHouse_GivenNonExistentHouseType_ReturnsException()
        //{
        //    // Arrange
        //    string houseTypeName = "nohouse";
        //    Dictionary<string, Type> test = new Dictionary<string, Type>();

        //    // Act
        //    var calculatedResult = _factory.CreateHouse(houseTypeName);

        //    // Assert
        //    //Assert.Throws<KeyNotFoundException>(() => calculatedResult.GetType(GetType());
        //    Assert.Throws(typeof(KeyNotFoundException), () => houseTypeName
        //    //Assert.IsInstanceOf<HouseWithPool>(calculatedResult);
        //}


        //[Test]
        //public void LoadHouseByReflection_Get_Return_AvailableHouses(Type availableHouseTypes)
        //{
        //  Arrange
        //    

        //  Act
        //    

        //  Assert
        //    Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        //}

    }
}