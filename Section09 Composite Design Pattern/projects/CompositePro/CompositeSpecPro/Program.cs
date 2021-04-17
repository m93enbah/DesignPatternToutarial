using CompositeSpecPro.Enums;
using CompositeSpecPro.Filters;
using CompositeSpecPro.Interfaces.Filters;
using CompositeSpecPro.Models;
using System;
using System.Collections.Generic;

namespace CompositeSpecPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Meduim);
            var house = new Product("House", Color.Blue, Size.Large);

            var prods = new List<Product>() { apple, tree, house };

            //each time that we need new filter feature, we need to modify new filter feature in the , so //the solution is used with Open Closed Design Pattern
            var pf = new ProductFilter();
            Console.WriteLine("Green Products (old)");
            foreach (var p in pf.FilterByColor(prods, Color.Green)) { Console.WriteLine(p.Name); }


            var bf = new BetterFilter();
            Console.WriteLine("Better Filter");

            foreach (var p in bf.Filter(prods, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("With Multiple Better Filter");
            foreach (var p in bf.Filter(prods, new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Meduim))))
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
    }
}
