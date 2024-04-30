using BaldursGate4.Enemy;
using BaldursGate4.Factory;
using BaldursGate4.Logger;
using BaldursGate4.Player;

namespace BaldursGate4.GameControl
{
    public class Game : IGame
    {
        //fields
        protected Random random = new Random();
        protected IConsoleLogger logger = new ConsoleLogger();
        public Game() { }
        //Properties
        public IPlayer Player { get; set; }
        public Races RaceName { get; set; }
        //Methods
        public void CharacterCreation()
        {
            var racesCount = Enum.GetNames(typeof(Races)).Length + 1;
            RaceName = (Races)random.Next(1, racesCount);
            CharacterCreator creator = new CharacterCreator();
            Player = creator.Create(RaceName);
        }
        public void StoryTelling()
        {
            logger.DisplayMessage("Our journey begins in the Darkest Dungeons of GIT, you only have a dagger and a gitbash manual");
            logger.DisplayMessage($"You are a {RaceName}.");
            Console.ReadLine();
            Player.DisplayStats();
            Console.ReadLine();
        }
        public void EventProgression()
        {
            int totalDamage = 0;
            int killCount = 0;
            while (Player.Hitpoints > 0)
            {

                var monsterCount = Enum.GetNames(typeof(EnemyTypes)).Length + 1;
                EnemyTypes enemyName = (EnemyTypes)random.Next(1, monsterCount);
                EnemyCreator enemyCreator = new EnemyCreator();
                IEnemy enemy = enemyCreator.Create(enemyName);

                logger.DisplayMessage($"You encounter a wild {enemy.Name}, it has {enemy.Hitpoints} hitpoints.");
                Console.ReadLine();

                while (enemy.Hitpoints > 0 && Player.Hitpoints > 0)
                {
                    int playerDamage;
                    int monsterDamage;


                    playerDamage = Player.PlayerAttack();
                    totalDamage += playerDamage;
                    enemy.TakeDamage(playerDamage);
                    Console.ReadLine();

                    monsterDamage = enemy.MonsterAttack();
                    Player.TakeDamage(monsterDamage);
                    Console.ReadLine();
                    if (enemy.Hitpoints <= 0)
                    {
                        killCount++;
                        if (enemy.ChanceToDropLoot())
                        {
                            Player.PickupWeapon(enemy.DropWeapon());
                        }
                    }

                }
                Console.ReadLine();
                Console.Clear();
            }
            logger.DisplayMessage("The story ends, GIT always wins.");
            logger.DisplayMessage($"Total damage dealt: {totalDamage}.");
            logger.DisplayMessage($"Enemies killed: {killCount}.");
            Console.ReadLine();

        }
    }
}
