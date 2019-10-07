namespace TypesOfVehicles
{
    class VehicleDatabase
    {
        public int GetNumberOfWheels(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Car": return 4;
                case "Motorcycle": return 2;
                case "Boat": return 0;
                case "Aeroplane": return 3;
                case "Helicopter": return 3;
                default: break;
            }

            var vehicleNotInDatabase = -1;
            return vehicleNotInDatabase;
        }

        public bool ConfirmVehicleCanFly(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Car": return false;
                case "Motorcycle": return false;
                case "Boat": return false;
                case "Aeroplane": return true;
                case "Helicopter": return true;
                default: break;
            }

            return false;
        }

        public bool ConfirmVehicleIsAquatic(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Car": return false;
                case "Motorcycle": return false;
                case "Boat": return true;
                case "Aeroplane": return false;
                case "Helicopter": return false;
                default: break;
            }

            return false;
        }
    }
}
