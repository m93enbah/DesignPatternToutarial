using System;
using DoFactoryTemplateDesignPro.Templates;

namespace DoFactoryTemplateDesignPro
{
    //Template Design Pattern : 
    // Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
    // Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            Console.ReadKey();
        }
    }
}
