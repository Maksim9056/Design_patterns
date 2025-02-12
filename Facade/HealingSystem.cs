using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HealingSystem
    {
        public void Heal(int amount)
        {
            Console.WriteLine($"Игрок восстанавливает {amount} единиц здоровья!");
        }
    }

}
