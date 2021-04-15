using static System.Console;
namespace doFactoryBridge
{
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            WriteLine("ConcreteImplementorB Operation");
        }
    }
}
