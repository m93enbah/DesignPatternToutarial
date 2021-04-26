using DoFactoryProxy2Pro.Models;
using static System.Console;
namespace DoFactoryProxy2Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create math proxy

            MathProxy proxy = new MathProxy();

            // Do the math
            WriteLine("4 + 2 = " + proxy.Add(4, 2));
            WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            WriteLine("4 / 2 = " + proxy.Div(4, 2));
            ReadKey();
        }
    }
}
