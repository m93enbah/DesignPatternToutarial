using AbstractFactoryPro.Interfaces;
using AbstractFactoryPro.Models;
using System;

namespace AbstractFactoryPro.Factories
{
    public enum AvailableDrink
    {
        Coffee,
        Tea
    }

    public class HotDrinkFactory 
    {
        public static IHotDrink Create(AvailableDrink name)
        {
            switch (name) 
            {
                case AvailableDrink.Coffee:
                    return new Coffee();
                case AvailableDrink.Tea:
                    return new Tea();
                default:
                    throw new ArgumentNullException($"Provider is not supported");
            }
        }
    }
}
