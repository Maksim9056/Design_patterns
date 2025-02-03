using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class VectorRenderer : IRenderer
    {
        public void RenderCircle(float x, float y, float size)
        {
            Console.WriteLine($"Drawing vector RenderCircle circle {x},{y},{size}");
        }

        public void RenderLine(float x, float y, float radias)
        {
            Console.WriteLine($"Drawing vector RenderLine square  {x},{y},{radias}");
        }
    }
}
