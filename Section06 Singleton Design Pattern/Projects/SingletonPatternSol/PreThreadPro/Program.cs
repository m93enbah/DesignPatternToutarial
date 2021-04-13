using System.Threading.Tasks;
using static System.Console;

namespace PreThreadPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() =>
            {
                WriteLine($"t1: " + PerThreadSingleton.Instance.Id);
            });
            var t2 = Task.Factory.StartNew(() =>
            {
                WriteLine($"t2: " + PerThreadSingleton.Instance.Id);
                WriteLine($"t2 again: " + PerThreadSingleton.Instance.Id);
            });
            Task.WaitAll(t1, t2);
            ReadLine();
        }
    }
}
