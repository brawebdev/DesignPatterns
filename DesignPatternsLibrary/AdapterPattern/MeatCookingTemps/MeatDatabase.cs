using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.MeatSafeCookingTemp
{
    public enum TemperatureType
    {
        Faherenheit,
        Celsius
    }

    //Legacy API which needs to be converted to new structure

    class MeatDatabase
    {
        public float GetSafeCookTemp(string meat, TemperatureType tempType)
        {
            if (tempType == TemperatureType.Faherenheit)
            {
                switch (meat)
                {
                    case "beef":
                    case "pork":
                        return 145f;

                    case "chicken":
                    case "turkey":
                        return 165f;

                    default:
                        return 165f;
                }
            }

            return 0;
        }
        public int GetCaloriesPerOunce(string meat)
        {
            switch (meat.ToLower())
            {
                case "beef": return 71;
                case "pork": return 69;
                case "chicken": return 66;
                case "turkey": return 38;
                default: return 0;
            }
        }

        public double GetProteinPerOunce(string meat)
        {
            switch (meat.ToLower())
            {
                case "beef": return 7.33f;
                case "pork": return 7.67f;
                case "chicken": return 8.57f;
                case "turkey": return 8.5f;
                default: return 0d;
            }
        }
    }
}
