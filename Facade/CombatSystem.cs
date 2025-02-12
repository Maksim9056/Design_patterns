using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CombatSystem
    {
        public void AttackEnemy(string enemy)
        {
            Console.WriteLine($"Игрок атакует {enemy} мечом!");
        }
    }

}
