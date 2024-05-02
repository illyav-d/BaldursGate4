using GitGate4.Factory;
using GitGate4.Logger;

namespace GitGate4.Enemy
{
    public class CriticalMonster : EnemyCharacter
    {
        public CriticalMonster(Random random, IConsoleLogger logger, IWeaponCreator weaponCreator) : base(random, logger, weaponCreator)
        {
            Name = "Git Mergeling";
            Hitpoints = 50;
            MinDamage = 1;
            MaxDamage = 2;
        }

        public override int MonsterAttack(IConsoleLogger logger)
        {
            int damage = 0;

            if (Hitpoints > 0)
            {
                damage = _random.Next(this.MinDamage, this.MaxDamage + 1);
                int critChance = _random.Next(1, 101);


                if (critChance <= 20)
                {
                    logger.DisplayMessage($"{this.Name} does a critical hit!");
                    damage = damage * 2;
                }
                logger.DisplayMessage($"It deals {damage} damage.");
            }

            return damage;
        }
    }
}
