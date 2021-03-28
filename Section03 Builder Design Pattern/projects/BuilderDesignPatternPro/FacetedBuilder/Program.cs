using FacetedBuilderPro.Builder;
using FacetedBuilderPro.Models;
using static System.Console;
namespace FacetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();

            //it will internally call implicit conversion PersonBuilder to Person
            Person personBuilder = pb.works.At("Fabrikana").AsA("Developer").Earning(2000)
                           .Address.At("AliBaba").WithPostCode("POB").In("Jordan");
            WriteLine(personBuilder.ToString());
            ReadLine();
        }
    }
}
