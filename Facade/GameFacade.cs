using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class GameFacade
    {
        private readonly CombatSystem _combatSystem;
        private readonly MagicSystem _magicSystem;
        private readonly HealingSystem _healingSystem;

        public GameFacade()
        {
            _combatSystem = new CombatSystem();
            _magicSystem = new MagicSystem();
            _healingSystem = new HealingSystem();
        }

        public void StyleFight(string enemy, string spellName, int amount)
        {
            _combatSystem.AttackEnemy(enemy);

            _magicSystem.CastSpell(spellName);
            _healingSystem.Heal(amount);

        }
       
    }

}
