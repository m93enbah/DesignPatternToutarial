using OpenClosedPrinciple.Filters;
using OpenClosedPrinciple.Models;
using OpenClosedPrinciple.Specifications;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Meduim);
            var house = new Product("House", Color.Blue, Size.Large);

            var prods = new List<Product>(){ apple, tree, house };

            //the hard code way , the check occur manually 
            var pf = new ProductFilter();
            Console.WriteLine("Green Products (old)");
            foreach (var p in pf.FilterByColor(prods, Color.Green)) 
            {
                Console.WriteLine(p.Name);
            }

            //with using BetterFilter i pass two things : list of Products , ISpecification
            var bf = new BetterFilter();
            Console.WriteLine("Better Filter");

            foreach (var p in bf.Filter(prods, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine(p.Name);
            }

            //the same thing but we create new Specification that contains color and size specifications 
            Console.WriteLine("With Multiple Better Filter");
            foreach (var p in bf.Filter(prods, new AndSpecification<Product>(new ColorSpecification(Color.Green),new SizeSpecification(Size.Meduim))))
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadLine();
        }
    }
}
