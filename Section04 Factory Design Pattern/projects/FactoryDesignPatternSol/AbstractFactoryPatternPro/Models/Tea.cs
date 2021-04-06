using AbstractFactoryPatternPro.Interfaces;
using System;

namespace AbstractFactoryPatternPro.Models
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }
}
