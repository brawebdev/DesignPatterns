using System;

namespace AdapterPattern.MeatSafeCookingTemp
{
    class Meat
    {
        protected string MeatName;
        protected float SafeCookingTempFahrenheit;
        protected float SafeCookTempCelsius;
        protected double CaloriesPerOunce;
        protected double ProteinPerOunce;

        public Meat(string meat)
        {
            MeatName = meat;
        }

        public virtual void LoadData()
        {
            Console.WriteLine($"\nMeat: {MeatName},");
        }
    }
}
