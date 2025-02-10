using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Supplier :IObserver
    {
        private string _nickname_Supplier;

        public Supplier(string nickname)
        {
            _nickname_Supplier = nickname;
        }
        public void Update(string message)
        {
            Console.WriteLine($"Поставщик [{_nickname_Supplier}] получил новое сообщение: {message}");
        } 
    
    }
}
