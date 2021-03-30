using FactoryDesignPatternSol.Models;
using System;
using System.Threading.Tasks;
using static System.Console;
namespace FactoryDesignPatternSol
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            //WriteLine(point.ToString());


            //var point2 = Point.NewCartesianPoint(10, 20);
            //WriteLine(point2.ToString());
            //ReadLine();


            //it will call the async factory method that it will return the class itself
            await Foo.CreateAsync();
            ReadLine();

        }
    }
}
