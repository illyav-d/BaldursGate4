using System;

namespace BaldursGate4.Enemy
{
    public class CriticalMonster : EnemyCharacter
    {
        public CriticalMonster()
        {
            Name = "Git Mergeling";
            Hitpoints = 60;
            MinDamage = 1;
            MaxDamage = 3;
        }

        public override int MonsterAttack()
        {
            int damage = 0;

            if (Hitpoints > 0)
            {
                damage = _random.Next(this.MinDamage, this.MaxDamage + 1);
                int critChance = _random.Next(1, 101);


                if (critChance <= 20)
                {
                    _logger.DisplayMessage($"{this.Name} does a critical hit!");
                    damage = damage * 2;
                }
                _logger.DisplayMessage($"It deals {damage} damage.");
            }
            
            return damage;
        }
    }
}
