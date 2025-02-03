using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {
        private float X, Y, Radius;

        public Circle(IRenderer renderer, float x, float y, float radius) : base(renderer)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Draw()
        {
            Renderer.RenderCircle(X, Y, Radius);

        }
    }
}
