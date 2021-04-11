using DoFactoryAbstractPro.Factory;
using System;

namespace DoFactoryAbstractPro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory #1
            var factory1 = new ProductAFactory();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            var factory2 = new ProductBFactory();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
