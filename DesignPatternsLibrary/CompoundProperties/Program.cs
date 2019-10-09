using System;

namespace CompoundProperties
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var water = new CompoundDetails("Water");
            water.Display();

            var benzene = new CompoundDetails("Benzene");
            benzene.Display();

            var ethanol = new CompoundDetails("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}
