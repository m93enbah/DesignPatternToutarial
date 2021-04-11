using ICloneablePro.Models;
using static System.Console;
namespace ICloneablePro
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "John", "Smith" },new Address("London St",123));

            WriteLine(john.ToString());

            //this way is inefficent
            //var jane = john;
            //jane.Names[0] = "Jane";


            //we see that it will make shallow copy which make the two refernces
            //refer to same instance object 
            var jane2 = (Person)john.Clone();
            jane2.Address.HouseNumber = 2345;
            WriteLine(jane2.ToString());

           ReadLine();
        }
    }
}
