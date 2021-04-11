using Section05SecFactoryBuilder.Builder;
using Section05SecFactoryBuilder.Interfaces;
using System;

namespace Section05SecFactoryBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder;

            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
