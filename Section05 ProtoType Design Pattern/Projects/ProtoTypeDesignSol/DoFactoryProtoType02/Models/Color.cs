using DoFactoryProtoType02.Interfaces;
using System;

namespace DoFactoryProtoType02.Models
{
    public class Color : IColorPrototype
    {
        public int _red;
        public int _green;
        public int _blue;

        // Constructor

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy
        public IColorPrototype Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);
            //apply shallow copy
            return this.MemberwiseClone() as IColorPrototype;
        }
    }
}
