using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Customer : IObserver
    {
        private string _nickname_Customer;

        public Customer(string nickname)
        {
            _nickname_Customer = nickname;
        }
        public void Update(string message)
        {
            Console.WriteLine($"Покупатель [{_nickname_Customer}] получил новое сообщение: {message}");
        }
    }
}
