using AbstractFactoryPro.Factories;
using AbstractFactoryPro.Interfaces;
using static System.Console;

namespace AbstractFactoryPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine =  HotDrinkFactory.Create(AvailableDrink.Tea);
            IHotDrink drink = machine.Prepare(100);
            drink.Consume();
            ReadLine();
        }
    }
}
