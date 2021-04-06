using AbstractFactoryPatternPro.Factories;
using AbstractFactoryPatternPro.Interfaces;
using System;

namespace AbstractFactoryPatternPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            //drink.Consume();

            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
