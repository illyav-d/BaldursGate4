using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaldursGate4.Enemy
{
    public class ShieldMonster: EnemyCharacter
    {
        public ShieldMonster()
        {
            Name = "Git Basher";
            Hitpoints = 100;
            MinDamage = 1;
            MaxDamage = 2;
        }

        public override void TakeDamage(int damage)
        {
            int blockChance = _random.Next(1, 101);

            if (blockChance <= 25)
            {
                _logger.DisplayMessage($"{this.Name} blocks some of your damage!");
                damage -= 2;
            }

            this.Hitpoints -= damage;
            _logger.DisplayMessage($"The enemy takes {damage} damage.");

            if (this.Hitpoints <= 0)
            {
                _logger.DisplayMessage("The enemy " + this.Name + " dies.");
                this.DropWeapon();
            }
            else
            {
                _logger.DisplayMessage($"The enemy has {this.Hitpoints} hitpoints left.");
            }
        }
    }
}
