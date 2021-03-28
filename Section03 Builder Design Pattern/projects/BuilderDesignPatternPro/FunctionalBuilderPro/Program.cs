using FunctionalBuilderPro.Builders;
using System;
using FunctionalBuilderPro.Extensions;
namespace FunctionalBuilderPro
{
    class Program
    {
        static void Main(string[] args)
        {
            //we see that we call chain method of functional builder to set multiple properities 
            var pb = new PersonBuilder();
            var person = pb.Called("Dmitri").SetArea("Area 1").WorksAsA("Programmer").Build();
            Console.WriteLine($"{person.Name} - {person.Area} - {person.Position}");
            Console.ReadLine();
        }
    }
}
