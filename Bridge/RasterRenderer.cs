using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float x, float y, float size)
        {
            Console.WriteLine($"RenderCircle Square at ({x}, {y}) with size {size}");

        }

        public void RenderLine(float x, float y, float radias)
        {
            Console.WriteLine($"RenderLine circle at ({x}, {y}) with radius {radias}");

        }
    }
}
