using InnerFactoryPro.Models;
using System;
using static System.Console;

namespace InnerFactoryPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.PointFactory.NewPolarPoint(1.0, Math.PI / 2);
            WriteLine(point.ToString());
        }
    }
}
