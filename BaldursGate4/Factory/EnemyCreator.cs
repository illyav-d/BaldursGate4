using BaldursGate4.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaldursGate4.Factory
{
    public class EnemyCreator
    {
        public IEnemy createEnemy(EnemyTypes enemy)
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
