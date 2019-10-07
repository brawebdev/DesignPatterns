using System;

namespace TypesOfVehicles
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            VehicleDetails car = new VehicleDetails("Car");
            car.LoadData();

            VehicleDetails boat = new VehicleDetails("Boat");
            boat.LoadData();

            VehicleDetails motorcycle = new VehicleDetails("Motorcycle");
            motorcycle.LoadData();

            VehicleDetails aeroplane = new VehicleDetails("Aeroplane");
            aeroplane.LoadData();

            VehicleDetails helicopter = new VehicleDetails("Helicopter");
            helicopter.LoadData();

            Console.ReadKey();
        }
    }
}
