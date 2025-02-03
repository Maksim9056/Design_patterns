using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Square : Shape
    {
        private float X, Y, Size;

        public Square(IRenderer renderer, float x, float y, float size) : base(renderer)
        {
            X = x;
            Y = y;
            Size = size;
        }

        public override void Draw()
        {
            Renderer.RenderLine(X, Y, Size);

        }
    }
}
