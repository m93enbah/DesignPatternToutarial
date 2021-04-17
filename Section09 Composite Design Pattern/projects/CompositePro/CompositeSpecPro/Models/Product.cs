﻿using CompositeSpecPro.Enums;
using System;

namespace CompositeSpecPro.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Product(string name, Color color, Size size)
        {
            if (name == null) { throw new ArgumentNullException(paramName: nameof(name)); }
            Name = name;
            Color = color;
            Size = size;
        }
    }
}
