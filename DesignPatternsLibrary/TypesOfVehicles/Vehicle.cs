using System;

namespace TypesOfVehicles
{
    class Vehicle
    {
        protected string VehicleType;
        protected int NumberOfWheels;
        protected bool VehicleCanFly;
        protected bool VehicleIsAquatic;

        public Vehicle(string vehicleType)
        {
            VehicleType = vehicleType;
        }

        public virtual void LoadData()
        {
            Console.WriteLine($"\nVehicle: {VehicleType},");
        }
    }
}
