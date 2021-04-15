using System;

namespace doFactoryBridge
{
    //Summary:  Decouple an abstraction from its implementation so that the two can vary independently.
    //so all the terminal classes that inherit from the Implementor like ConcreteImplementorA,ConcreteImplementorB 
    //the base class are used as property on the Abstraction class and use the property to generate what we want
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
