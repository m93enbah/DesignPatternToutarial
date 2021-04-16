using BridgePatternPro.Interface;
using static System.Console;

namespace BridgePatternPro.Models
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            WriteLine($"Drawing a circle of radius {radius}");
        }
    }
}
