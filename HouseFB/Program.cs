using HouseFB;

try
{
    House house = House
        .Builder
        .SetStreetAddress("10963 Lindblade Street, Culver City, CA 90066")
        .WithSwimmingPool()
        .AddNoOfRooms(3)
        .AddNoOfWindows(12)
        .SetNoOfParkingSpotsInGarage(2)
        .Build();

    Console.WriteLine(house);
}
catch (ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}

