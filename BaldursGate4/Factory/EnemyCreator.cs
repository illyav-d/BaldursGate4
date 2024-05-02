using GitGate4.Enemy;
using GitGate4.Logger;

namespace GitGate4.Factory
{
    public class EnemyCreator : IEnemyCreator
    {
        IConsoleLogger _logger;
        Random _random = new Random();
        IWeaponCreator _weaponCreator;
        public EnemyCreator(IConsoleLogger logger, IWeaponCreator weaponCreator)
        {
            _logger = logger;
            _weaponCreator = weaponCreator;

        }
        public IEnemy Create(EnemyTypes enemy)
        {
            switch (enemy)
            {
                case EnemyTypes.Default:
                    return new DefaultMonster(_random, _logger, _weaponCreator);

                case EnemyTypes.Shield:
                    return new ShieldMonster(_random, _logger, _weaponCreator);

                case EnemyTypes.Critical:
                    return new CriticalMonster(_random, _logger, _weaponCreator);
                default:
                    throw new ArgumentException();
            }
        }


    }
}
