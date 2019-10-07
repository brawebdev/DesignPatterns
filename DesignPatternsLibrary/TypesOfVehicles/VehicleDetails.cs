using System;
using System.Collections.Generic;
using System.Text;

namespace TypesOfVehicles
{
    class VehicleDetails : Vehicle
    {
        public VehicleDetails(string vehicleType) : base(vehicleType)
        {
        }

        public override void LoadData()
        {
            var vehicleDatabase = new VehicleDatabase();
            NumberOfWheels = vehicleDatabase.GetNumberOfWheels(VehicleType);
            VehicleIsAquatic = vehicleDatabase.ConfirmVehicleIsAquatic(VehicleType);
            VehicleCanFly = vehicleDatabase.ConfirmVehicleCanFly(VehicleType);

            base.LoadData();

            Console.WriteLine($"Vehicle Can Fly: {VehicleCanFly}");
            Console.WriteLine($"Vehicle is Aquatic: {VehicleIsAquatic}");
            Console.WriteLine($"Vehicle has {NumberOfWheels} wheels");
        }
    }
}
