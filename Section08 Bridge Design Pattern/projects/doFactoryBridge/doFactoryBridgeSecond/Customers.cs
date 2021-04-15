using System;

namespace doFactoryBridgeSecond
{
    //terminal class that inherit from the CustomerBase abstract class
    class Customers : CustomersBase
    {
        // Constructor
        public Customers(string group)
          : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
