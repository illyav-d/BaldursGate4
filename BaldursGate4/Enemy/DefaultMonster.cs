using GitGate4.Factory;
using GitGate4.Logger;

namespace GitGate4.Enemy
{
    public class DefaultMonster : EnemyCharacter
    {
        public DefaultMonster(Random random, IConsoleLogger logger, IWeaponCreator weaponCreator) : base(random, logger, weaponCreator)
        {
            Name = "Git Noob";
        }
    }
}
