using System;

namespace AdapterPattern
{
    internal static class ShoppingPortalClient
    {
        static void Main(string[] args)
        {
            ITarget adapter = new VendorAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }
    }
}
