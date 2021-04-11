using CopyConstPro.Models;
using static System.Console;
namespace CopyConstPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee("John", new Address("123 London Road", "London", "UK"));

            //var chris = john;
            var chris = new Employee(john);

            chris.Name = "Chris";
            WriteLine(john); // oops, john is called chris
            WriteLine(chris);
        }
    }
}
