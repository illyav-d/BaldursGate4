﻿using GitGate4.Factory;
using GitGate4.Logger;

namespace GitGate4.Enemy
{
    public class ShieldMonster : EnemyCharacter
    {
        public ShieldMonster(Random random, IConsoleLogger logger, IWeaponCreator weaponCreator) : base(random, logger, weaponCreator)
        {
            Name = "Git Basher";
            Hitpoints = 100;
            MinDamage = 1;
            MaxDamage = 1;
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
            base._logger.DisplayMessage($"The enemy takes {damage} damage.");

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
