using HouseF.Houses;
using NUnit.Framework;
using System;
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
        }

        [TestCase("standardhouse")]
        public void GetHouseFromDictionary_Get_Return_StandardHouseType(string houseTypeName)
        {
            //Arrange
            MethodInfo method = typeof(HouseFactory)
                .GetMethod("GetHouseFromDictionary", BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null) Assert.Fail("Could not find method GetHouseFromDictionary");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This house is located at 10963 Lindblade Street, Culver City, California 92646.");
            sb.AppendLine("It has 4 rooms, 2 bathrooms and 12 windows.");
            sb.AppendLine("It has a garage with space for 2 cars.");

            string expectedOutput = sb.ToString();

            //Act
            object calculatedObject = method!.Invoke(new HouseFactory(), new object[] { houseTypeName });
            string calculatedResult = calculatedObject.ToString();

            Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        }

        [TestCase("belairdeluxehouse")]
        public void GetHouseFromDictionary_Get_Return_BelAirDeluxeHouseType(string houseTypeName)
        {
            MethodInfo method = typeof(HouseFactory)
                .GetMethod("GetHouseFromDictionary", BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null) Assert.Fail("Could not find method GetHouseFromDictionary");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This house is located at 281 Bentley Circle, Los Angeles, California 90049.");
            sb.AppendLine("It has 12 rooms, 10 bathrooms and 28 windows.");
            sb.AppendLine("It is a deluxe house that has both a swimming pool and a garage with space for 12 cars and: ");
            sb.AppendLine();
            sb.AppendLine("- a tennis court");
            sb.AppendLine("- an ocean view");
            sb.AppendLine("- a mountain view");
            sb.AppendLine("- marble floors");

            string expectedOutput = sb.ToString();

            // Act
            object calculatedObject = method!.Invoke(new HouseFactory(), new object[] { houseTypeName });
            string calculatedResult = calculatedObject.ToString();

            // Assert
            Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        }

        [TestCase("housewithpool")]
        public void GetHouseFromDictionary_Get_Return_HouseWithPoolType(string houseTypeName)
        {
            //Arrange
            MethodInfo method = typeof(HouseFactory)
                .GetMethod("GetHouseFromDictionary", BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null) Assert.Fail("Could not find method GetHouseFromDictionary");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This house is located at 975 Cheyenne Street, Costa Mesa, California 92626.");
            sb.AppendLine("It has 6 rooms, 2 bathrooms and 12 windows.");
            sb.AppendLine("It has a nice swimming pool.");

            string expectedOutput = sb.ToString();

            //Act
            object calculatedObject = method!.Invoke(new HouseFactory(), new object[] { houseTypeName });
            string calculatedResult = calculatedObject.ToString();

            Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        }

        [TestCase("housewithpoolandgarage")]
        public void GetHouseFromDictionary_Get_Return_HouseWithPoolandGarageType(string houseTypeName)
        {
            //Arrange
            MethodInfo method = typeof(HouseFactory)
                .GetMethod("GetHouseFromDictionary", BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null) Assert.Fail("Could not find method GetHouseFromDictionary");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This house is located at 965 Oasis Dr, Torrance, California 90502.");
            sb.AppendLine("It has 4 rooms, 2 bathrooms and 9 windows.");
            sb.AppendLine("It is very fancy and has both a swimming pool, and a garage with space for 2 cars.");

            string expectedOutput = sb.ToString();

            //Act
            object calculatedObject = method!.Invoke(new HouseFactory(), new object[] { houseTypeName });
            string calculatedResult = calculatedObject.ToString();

            Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        }

        [TestCase("tinyhouse")]
        public void GetHouseFromDictionary_Get_Return_TinyHouseType(string houseTypeName)
        {
            //Arrange
            MethodInfo method = typeof(HouseFactory)
                .GetMethod("GetHouseFromDictionary", BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null) Assert.Fail("Could not find method GetHouseFromDictionary");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This house is located at 100 Miniature Way, Smallville, Kansas 67524.");
            sb.AppendLine("It has 3 rooms, 1 bathrooms and 7 windows.");

            string expectedOutput = sb.ToString();

            //Act
            object calculatedObject = method!.Invoke(new HouseFactory(), new object[] { houseTypeName });
            string calculatedResult = calculatedObject.ToString();

            Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        }

        //[Test]
        //public void LoadHouseByReflection_Get_Return_AvailableHouses(Type availableHouseTypes)
        //{
        //    //Arrange
        //    MethodInfo method = typeof(HouseFactory)
        //        .GetMethod("GetHouseFromDictionary", BindingFlags.NonPublic | BindingFlags.Instance);

        //    if (method == null) Assert.Fail("Could not find method GetHouseFromDictionary");

        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("This house is located at 10963 Lindblade Street, Culver City, California 92646.");
        //    sb.AppendLine("It has 4 rooms, 2 bathrooms and 12 windows.");
        //    sb.AppendLine("It has a garage with space for 2 cars.");

        //    string expectedOutput = sb.ToString();

        //    //Act
        //    object calculatedObject = method!.Invoke(new HouseFactory(), new object[] { houseTypeName });
        //    string calculatedResult = calculatedObject.ToString();

        //    Assert.That(calculatedResult, Is.EqualTo(expectedOutput));
        //}

    }
}