﻿using AbstractFactoryPatternPro.Interfaces;
using AbstractFactoryPatternPro.Models;
using System;

namespace AbstractFactoryPatternPro.Factories
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
            return new Tea();
        }
    }

}
