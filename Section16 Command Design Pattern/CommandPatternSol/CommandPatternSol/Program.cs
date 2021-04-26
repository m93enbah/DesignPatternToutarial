using DoFactoryCommandPatternPro.Commands;
using System;

namespace DoFactoryCommandPatternPro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create receiver, assign to ConcreteCommand , Create Invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command on the Invoker instance
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
