using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype
{
    public abstract class Shape
    {
        public  string NameShape { get; set; }
        public  double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public double w { get; set; }

        public EnduranceShape Equipment { get; set; }

        // Абстрактный метод клонирования
        public abstract Shape Clone();

        public override string ToString()
        {
            return $"NameShape: {NameShape}, x: {x}, y: {y},  z: {z}, " +
                   $"w: {w}, EnduranceShape: {Equipment.Endurance}";
        }
    }
}
