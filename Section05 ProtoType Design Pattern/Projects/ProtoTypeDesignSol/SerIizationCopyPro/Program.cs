using SerIizationCopyPro.Extensions;
using SerIizationCopyPro.Models;
using static System.Console;

namespace SerIizationCopyPro
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
            WriteLine("--------------Copy----------------");
            WriteLine(john);
            WriteLine(copy);


            var jsonCopy = john.DeepCopyJSON();

            jsonCopy.Names[1] = "Smith";
            jsonCopy.Address.HouseNumber++;
            jsonCopy.Salary = 123000;

            WriteLine("-----------JSON Copy----------------");
            WriteLine(john);
            WriteLine(jsonCopy);


            var xmlCopy = john.DeepCopyXml();

            xmlCopy.Names[1] = "Smith";
            xmlCopy.Address.HouseNumber++;
            xmlCopy.Salary = 123000;

            WriteLine("-----------XML Copy----------------");
            WriteLine(john);
            WriteLine(xmlCopy);

            ReadLine();
        }
    }
}
