using Section05DoFactoryBuilderPro.Builder;
using Section05DoFactoryBuilderPro.Models;
using System;

namespace Section05DoFactoryBuilderPro
{
    class Program
    {
        public static void Main()
        {
            // Create director and builders

            Director director = new Director();

            var b1 = new ConcreteBuilder1();
            var b2 = new ConcreteBuilder2();

            // Construct two products

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user

            Console.ReadKey();
        }
    }
}
