using FacadeDesignPro.DotNetDesignPatternDemos.Structural.Facade;
using System;

namespace FacadeDesignPro
{
    class Program
    {
        public static void Main(String[] args)
        {
            //ShapeMaker shapeMaker = new ShapeMaker();

            //shapeMaker.drawCircle();
            //shapeMaker.drawRectangle();
            //shapeMaker.drawSquare();
            //Console.ReadLine();


            TestSuite tst = new TestSuite();
            tst.TestSizeThree();
            Console.ReadLine();
        }
    }
}
