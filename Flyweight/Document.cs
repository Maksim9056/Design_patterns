using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public  abstract class Document
    {
        protected long Count_page;
        public abstract void Create(double longitude, double latitude);

    }
}
