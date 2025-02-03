using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ImageProxy : IImage
    {
        private string _filename;

        private HighResImage _realImage;

        public ImageProxy(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null) 
            {
                Console.WriteLine("Изображение  не загружено,сейчас загружаем");
                _realImage = new HighResImage(_filename);

            }
            else
            {
                Console.WriteLine("Изображение было загружено, пользуемся кешированным.");

            }
            _realImage.Display();

        }
    }
}
