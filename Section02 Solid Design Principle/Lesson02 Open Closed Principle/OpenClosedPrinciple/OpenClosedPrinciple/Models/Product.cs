using System;

namespace OpenClosedPrinciple.Models
{
    public enum Color
    {
        Red,
        Green,
        Blue
    }
    public enum Size
    {
        Small,
        Meduim,
        Large,
        Yuge
    }

    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Product(string name, Color color, Size size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;
            Color = color;
            Size = size;
        }
    }
}
