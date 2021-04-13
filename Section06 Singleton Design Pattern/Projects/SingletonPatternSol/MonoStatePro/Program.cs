using static System.Console;

namespace MonoStatePro
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceo = new CEO();
            ceo.Name = "Adam";
            ceo.Age = 22;

            var ceo2 = new CEO();
            WriteLine(ceo2);
            ReadLine();
        }
    }
}
