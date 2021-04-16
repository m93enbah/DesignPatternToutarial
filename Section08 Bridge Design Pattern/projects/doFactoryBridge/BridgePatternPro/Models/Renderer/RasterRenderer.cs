using BridgePatternPro.Interface;
using static System.Console;

namespace BridgePatternPro.Models
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            WriteLine($"Drawing pixels for circle of radius {radius}");
        }
    }
}
