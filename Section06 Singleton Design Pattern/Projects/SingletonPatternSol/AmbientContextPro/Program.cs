using static System.Console;

namespace AmbientContextPro
{
    class Program
    {
        public static void Main(string[] args)
        {
            var house = new Building();
            //each group of instance has its own shared instance
            // ground floor
            //var e = 0;
            house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)/*, e*/));
            house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)/*, e*/));

            //each group of instance has its own shared instance
            // first floor
            //e = 3500;
            using (new BuildingContext(3500))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0) /*, e*/));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000) /*, e*/));
            }

            //each group of instance has its own shared instance
            // back to ground again
            // e = 0;
            house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)/*, e*/));

            WriteLine(house);
        }
    }
}
