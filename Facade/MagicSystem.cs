using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class MagicSystem
    {
        public void CastSpell(string spellName)
        {
            Console.WriteLine($"Игрок использует заклинание {spellName}!");
        }
    }

}
