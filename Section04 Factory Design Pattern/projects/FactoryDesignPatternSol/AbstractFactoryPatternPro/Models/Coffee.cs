using AbstractFactoryPatternPro.Interfaces;
using System;

namespace AbstractFactoryPatternPro.Models
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is delicious!");
        }
    }
}
