using MoreLinq;
using System.Collections.Generic;
using static System.Console;
namespace AdapterSimplePro
{
    //we will use adapter design pattern which convert the vector object which is rectangle 
    //into list of lines that will converted into collection of points


    //we have VectorObject which inherit from Collection<Line>
    //we have VectorRectangle which inherit from VectorObject
    //we have Line > Point Start,Point End
    class Program
    {
        public static readonly List<VectorObject> vectorObjects
            = new List<VectorObject>()
        {
                new VectorRectangle(1,1,10,10),
                new VectorRectangle(3,3,6,6)
        };

        public static void DrawPoint(Point p) 
        {
            Write(".");
        }

        static void Main(string[] args)
        {
            Draw();
            Draw();
            ReadLine();
            WriteLine("Hello World!");
        }


        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(pt => {
                        WriteLine($"({pt.X},{pt.Y})");
                    });                    
                }
            }
            ReadLine();
        }
    }
}
