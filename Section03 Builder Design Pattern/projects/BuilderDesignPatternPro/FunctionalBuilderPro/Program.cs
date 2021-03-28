using FunctionalBuilderPro.Builders;
using System;
using FunctionalBuilderPro.Extensions;
namespace FunctionalBuilderPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            var person = pb.Called("Dmitri").WorksAsA("Programmer").Build();
            Console.ReadLine();
        }
    }
}
