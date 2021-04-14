using Autofac;
using static System.Console;

namespace SingletonDISol
{
    public class Program
    {
        static void Main(string[] args)
        {
            //it will register EventBroker as singelton and Foo and new instance
            var builder = new ContainerBuilder();
            builder.RegisterType<EventBroker>().SingleInstance();
            builder.RegisterType<Foo>();

            using (var c = builder.Build())
            {
                var foo1 = c.Resolve<Foo>();
                var foo2 = c.Resolve<Foo>();
                //we see that the foo1 , foo2 is differnt but the broker is singleton so its refer to the same
                WriteLine(ReferenceEquals(foo1, foo2));
                WriteLine(ReferenceEquals(foo1.Broker, foo2.Broker));
            }
        }
    }
}
