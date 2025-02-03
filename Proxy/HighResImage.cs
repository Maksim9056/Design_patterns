using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class HighResImage : IImage
    {
        private string _filename;

        public HighResImage(string filename)
        {
            _filename = filename;
            LoadImage();
        }

        public void Display()
        {
            Console.WriteLine($"Отображение изображения {_filename}");
        }

        private void LoadImage()
        {
            Console.WriteLine($"Загрузка изображения {_filename}");
        }
    }
}
