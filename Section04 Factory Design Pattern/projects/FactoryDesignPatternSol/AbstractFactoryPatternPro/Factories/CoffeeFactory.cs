﻿using AbstractFactoryPatternPro.Interfaces;
using AbstractFactoryPatternPro.Models;
using System;

namespace AbstractFactoryPatternPro.Factories
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar, enjoy!");
            return new Coffee();
        }
    }
}
