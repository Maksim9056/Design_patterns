using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype
{
    public class Circle : Shape
    {

        public Circle(string nameShape, double X, double Y, double Z, double W, EnduranceShape equipment)
        {
            NameShape = nameShape;
            x = X;
            y  = Y;
            z = Z;
            w = W;
            Equipment = equipment;
        }

        public override Shape Clone()
        {  

            Circle clone = (Circle)this.MemberwiseClone();

            if (this.Equipment != null)
            {
                clone.Equipment = this.Equipment.Clone();
            }

            return clone;
        }
    }
}
