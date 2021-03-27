using FluentBuilderPro.Builder;
using FluentBuilderPro.Models;
using System;
using static System.Console;
namespace FluentBuilderPro
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var me = Person.New
              .Called("Dmitri")
              .WorksAsA("Quant")
              .Born(DateTime.UtcNow)
              .Build();
            WriteLine(me);
        }
    }
}
