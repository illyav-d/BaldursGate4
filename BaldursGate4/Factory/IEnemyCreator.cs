using GitGate4.Enemy;

namespace GitGate4.Factory
{
    public interface IEnemyCreator
    {
        IEnemy Create(EnemyTypes enemy);
    }
}