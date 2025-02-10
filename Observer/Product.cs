using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Product
    {
        private List<IObserver> _observers = new List<IObserver>();

        // Подписка
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        // Отписка
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Метод, вызываемый, когда в чат поступает новое сообщение
        public void PublishMessage(string message)
        {
            // Логика: кладём сообщение, затем оповещаем
            Notify(message);
        }

        // Оповещение всех подписчиков
        private void Notify(string message)
        {
            foreach (var obs in _observers)
            {
                obs.Update(message);
            }
        }
    }
}
