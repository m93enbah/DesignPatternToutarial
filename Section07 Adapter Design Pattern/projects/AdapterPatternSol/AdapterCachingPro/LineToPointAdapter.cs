using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace AdapterCachingPro
{
    public class LineToPointAdapter : IEnumerable<Point>
    {
        private static int count = 0;
        //by using cache which is used to store all the points with the hash code it refer
        static Dictionary<int, List<Point>> cache = new Dictionary<int, List<Point>>();
        private int hash;

        public LineToPointAdapter(Line line)
        {
            //we check to the line GetHashCode() which return X,Y GetHashCode()
            hash = line.GetHashCode();
            // we already have it
            if (cache.ContainsKey(hash)) 
                return; 

            WriteLine($"{++count}: Generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}] (with caching)");

            List<Point> points = new List<Point>();

            int left = Math.Min(line.Start.X, line.End.X);
            int right = Math.Max(line.Start.X, line.End.X);
            int top = Math.Min(line.Start.Y, line.End.Y);
            int bottom = Math.Max(line.Start.Y, line.End.Y);
            int dx = right - left;
            int dy = line.End.Y - line.Start.Y;

            if (dx == 0)
            {
                for (int y = top; y <= bottom; ++y)
                {
                    points.Add(new Point(left, y));
                }
            }
            else if (dy == 0)
            {
                for (int x = left; x <= right; ++x)
                {
                    points.Add(new Point(x, top));
                }
            }
            //on each line convert to point it will store to caching
            cache.Add(hash, points);
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return cache[hash].GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cache[hash].GetEnumerator();
        }
    }
}
