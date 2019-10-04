using System;

namespace AdapterPattern.MeatSafeCookingTemp
{
    internal static class SafeCookingTempsForMeat
    {
        static void Main(string[] args)
        {
            ////Non-adapted
            Meat unkown = new Meat("Beef");
            unkown.LoadData();

            //Adapted
            MeatDetails beef = new MeatDetails("Beef");
            beef.LoadData();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.LoadData();

            Console.ReadKey();
        }
    }
}
