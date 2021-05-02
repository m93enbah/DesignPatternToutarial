using DoFactoryIteratorDesignPro.Aggregators;
using DoFactoryIteratorDesignPro.Iterators;
using System;

namespace DoFactoryIteratorDesignPro
{ 

    //Iterator design pattern split into 3 parts 
    //A-Aggreagtor : which contains list of element and can use indexer to set items
    //(and Iterator initalizer that return new instnace of Iterator that call the con
    //(so you need only to store items inside the aggregator and createIterator method)
    //B-Iterator : which contain the assigment of the ConcreteAggregate with private ConcreteAggregate property
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate
            Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            //so the iterator is now accessable to the aggregator 
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}
