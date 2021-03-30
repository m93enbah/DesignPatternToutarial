using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternSol.Models
{
    public enum CoordinateSystem 
    {
        Cartesian,
        Polar
    }

    //in case that you have class point that contain two property that set in two way Cartesian or polar , 
    //it will make maintaince issues on switching and you have to pass the type you want to set the values a , b in both system
    //not practical way to initalize instances 
    //public class Point
    //{
    //    private double x, y;
        /// <summary>
        /// Initialize point from either cartesian or polar
        /// </summary>
        /// <param name="a">x if cartesian , rho if polar</param>
        /// <param name="b">y if cartesian , rho is polar</param>
        /// <param name="system"></param>
        //public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian) 
        //{
        //    switch (system) 
        //    {
        //        case CoordinateSystem.Cartesian:
        //            x = a;
        //            y = b;
        //            break;
        //        case CoordinateSystem.Polar:
        //            x = a * Math.Cos(b);
        //            y = a * Math.Sin(b);
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(system), system, null);
        //    }
        //}
    //}


    //with apply factory method
    public class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point NewCartesianPoint(double x, double y) 
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta) 
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        public override string ToString()
        {
            return $"X : {x} , Y : {y}";
        }
    }
}
