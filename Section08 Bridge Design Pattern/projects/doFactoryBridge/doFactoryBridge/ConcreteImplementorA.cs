using static System.Console;
namespace doFactoryBridge
{
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            WriteLine("ConcreteImplementorA Operation");
        }
    }
}
