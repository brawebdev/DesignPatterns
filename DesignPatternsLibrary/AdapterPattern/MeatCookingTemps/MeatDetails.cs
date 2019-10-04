using System;

namespace AdapterPattern.MeatSafeCookingTemp
{
    //Adaptor class, which wraps the meat class adn initializes that class's values
    class MeatDetails : Meat
    {
        private MeatDatabase meatDatabase;

        public MeatDetails(string name) : base(name)
        {
        }

        public override void LoadData()
        {
            meatDatabase = new MeatDatabase();

            SafeCookingTempFahrenheit = meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Faherenheit);
            SafeCookTempCelsius = meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Celsius);
            CaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(MeatName);
            ProteinPerOunce = meatDatabase.GetProteinPerOunce(MeatName);

            base.LoadData();
            Console.WriteLine($" Safe Cook Temp (F): {SafeCookingTempFahrenheit}");
            Console.WriteLine($" Safe Cook Temp (C): {SafeCookTempCelsius}");
            Console.WriteLine($" Calories per Ounce: {CaloriesPerOunce}");
            Console.WriteLine($" Protein per Ounce: {ProteinPerOunce}");
        }
    }
}
