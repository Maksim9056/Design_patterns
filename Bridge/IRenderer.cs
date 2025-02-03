using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IRenderer
    {
        void RenderLine(float x, float y, float radias);
        void RenderCircle(float x, float y, float size);
    }
}
