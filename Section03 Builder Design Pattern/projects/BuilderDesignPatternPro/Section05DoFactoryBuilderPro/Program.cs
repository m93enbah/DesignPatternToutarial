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

            //we call the 
            director.CallBuilder1();
            Product p1 = director.builder1.GetResult();
            p1.Show();

            director.CallBuilder2();
            Product p2 = director.builder2.GetResult();
            p2.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
