using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {

        public Rectangle(string nameShape, double X, double Y, double Z, double W, EnduranceShape equipment)
        {
            NameShape = nameShape;
            x = X;
            y = Y;
            z = Z;
            w = W;
            Equipment = equipment;
        }

        public override Shape Clone()
        {

            Rectangle clone = (Rectangle)this.MemberwiseClone();

            if (this.Equipment != null)
            {
                clone.Equipment = this.Equipment.Clone();
            }

            return clone;
        }

    }
}
