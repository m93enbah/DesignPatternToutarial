using DoFactoryProtoTypePro.Models;
using static System.Console;

namespace DoFactoryProtoTypePro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two instances and clone each
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            WriteLine("Cloned: {0}", c1.Id);

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            WriteLine("Cloned: {0}", c2.Id);

            // Wait for user
            ReadKey();
        }
    }
}
