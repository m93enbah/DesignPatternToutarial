using CopyInheritPro.Extensions;
using CopyInheritPro.Models;
using static System.Console;

namespace CopyInheritPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee();
            john.Names = new[] { "John", "Doe" };
            john.Address = new Address { HouseNumber = 123, StreetName = "London Road" };
            john.Salary = 321000;
            var copy = john.DeepCopy();

            copy.Names[1] = "Smith";
            copy.Address.HouseNumber++;
            copy.Salary = 123000;

            WriteLine(john);
            WriteLine(copy);
            ReadLine();
        }
    }
}
