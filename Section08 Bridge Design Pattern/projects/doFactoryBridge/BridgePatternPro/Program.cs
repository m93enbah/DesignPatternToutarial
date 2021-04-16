using Autofac;
using BridgePatternPro.Interface;
using BridgePatternPro.Models;
using static System.Console;

namespace BridgePatternPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var raster = new RasterRenderer();
            var vector = new VectorRenderer();
            var circle = new Circle(vector, 5);
            circle.Draw();
            circle.Resize(2);
            circle.Draw();

            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(),
              p.Positional<float>(0)));
            using (var c = cb.Build())
            {
                var circle2 = c.Resolve<Circle>(
                  new PositionalParameter(0, 5.0f)
                );
                circle2.Draw();
                circle2.Resize(2);
                circle2.Draw();
            }
        }
    }
}
