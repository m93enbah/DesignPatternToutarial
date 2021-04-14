using MoreLinq;
using System.Collections.Generic;
using static System.Console;
namespace AdapterCachingPro
{
    class Program
    {
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
    {
      new VectorRectangle(1, 1, 10, 10),
      new VectorRectangle(3, 3, 6, 6)
    };

        // the interface we have
        public static void DrawPoint(Point p)
        {
            Write(".");
        }

        static void Main(string[] args)
        {
            Draw();
            Draw();
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
        }
    }
}
