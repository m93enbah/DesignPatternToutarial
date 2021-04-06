﻿namespace FactoryClassPro.Models
{
    public class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"X : {x} , Y : {y}";
        }
    }
}
