using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TextDocument :Document
    {
        public TextDocument()
        {
            Count_page = 16;
        }

        public override void Create(double longitude, double latitude)
        {
            Console.WriteLine("Создан текстовый документ  из 16 страниц; координаты: {0} широты и {1} долготы",latitude, longitude);
        }

    }
}
