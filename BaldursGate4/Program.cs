using BaldursGate4.Enemy;
using BaldursGate4.Factory;
using BaldursGate4.Logger;
using BaldursGate4.Player;
using BaldursGate4.Weapon;

namespace BaldursGate4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Variables
            Random random = new Random();
            ConsoleLogger logger = new ConsoleLogger();

            // Race + Char
            var racesCount = Enum.GetNames(typeof(Races)).Length + 1;
            Races raceName = (Races)random.Next(1, racesCount);
            CharacterCreator creator = new CharacterCreator();
            IPlayer player = creator.createACharacter(raceName);

            //Display
            logger.DisplayMessage("Our journey begins in the Darkest Dungeons of GIT, you only have a dagger and a gitbash manual");
            logger.DisplayMessage($"You are a {raceName}.");
            Console.ReadLine();
            player.DisplayStats();
            Console.ReadLine();

            //Progression
            while(player.Hitpoints > 0)
            {
                var monsterCount = Enum.GetNames(typeof(EnemyTypes)).Length + 1;
                EnemyTypes enemyName = (EnemyTypes)random.Next(1, monsterCount);
                EnemyCreator enemyCreator = new EnemyCreator();
                IEnemy enemy = enemyCreator.createEnemy(enemyName);

                logger.DisplayMessage($"You encounter a wild {enemy.Name}, it has {enemy.Hitpoints} hitpoints.");
                Console.ReadLine();

                while (enemy.Hitpoints > 0 && player.Hitpoints > 0)
                {
                    int playerDamage = 0;
                    int monsterDamage = 0;

                    playerDamage = player.PlayerAttack();
                    enemy.TakeDamage(playerDamage);
                    Console.ReadLine();

                    monsterDamage = enemy.MonsterAttack();
                    player.TakeDamage(monsterDamage);
                    Console.ReadLine();
                }
            }
        }
    }
}
