using GitGate4.Enemy;

namespace GitGate4.Factory
{
    public class EnemyCreator : IEnemyCreator
    {
        public IEnemy Create(EnemyTypes enemy)
        {
            switch (enemy)
            {
                case EnemyTypes.Default:
                    return new DefaultMonster();

                case EnemyTypes.Shield:
                    return new ShieldMonster();

                case EnemyTypes.Critical:
                    return new CriticalMonster();
                default:
                    throw new ArgumentException();
            }
        }


    }
}
