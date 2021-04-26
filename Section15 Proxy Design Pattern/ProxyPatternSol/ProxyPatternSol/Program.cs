using DoFactoryProxyPatternPro.Subjects;
using static System.Console;
namespace DoFactoryProxyPatternPro
{
    //Provide a surrogate or placeholder for another object to control access to it.
    class Program
    {
        static void Main(string[] args)
        {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();
            ReadKey();
        }
    }
}
