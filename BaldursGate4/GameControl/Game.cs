using GitGate4.Enemy;
using GitGate4.Factory;
using GitGate4.Logger;
using GitGate4.Player;

namespace GitGate4.GameControl
{
    public class Game : IGame
    {
        //fields
        Random _random = new Random();
        IConsoleLogger _logger;
        ICharacterCreator _characterCreator;
        IEnemyCreator _enemyCreator;

        public Game(IConsoleLogger logger, ICharacterCreator characterCreator, IEnemyCreator enemyCreator)
        {

            _logger = logger;
            _characterCreator = characterCreator;
            _enemyCreator = enemyCreator;
        }
        //Properties
        public IPlayer Player { get; set; }
        public IEnemy Enemy { get; set; }
        public Races RaceName { get; set; }
        //Methods
        public void CharacterCreation()
        {
            //TODO: Vraag Parameter in methode + Iplayer in constr? => Constructor/Fields beter gebruiken (als klasse het voorziet, gebruik dat)
            var racesCount = Enum.GetNames(typeof(Races)).Length + 1;
            RaceName = (Races)_random.Next(1, racesCount);
            Player = _characterCreator.Create(RaceName);
        }
        public void StoryTelling()
        {
            _logger.DisplayMessage("Our journey begins in the Darkest Dungeons of GIT, you only have a dagger and a gitbash manual");
            _logger.DisplayMessage($"You are a {RaceName}.");
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
                EnemyTypes enemyName = (EnemyTypes)_random.Next(1, monsterCount);
                Enemy = _enemyCreator.Create(enemyName);

                _logger.DisplayMessage($"You encounter a wild {Enemy.Name}, it has {Enemy.Hitpoints} hitpoints.");
                Console.ReadLine();

                while (Enemy.Hitpoints > 0 && Player.Hitpoints > 0)
                {
                    int playerDamage;
                    int monsterDamage;


                    playerDamage = Player.PlayerAttack();
                    totalDamage += playerDamage;
                    Enemy.TakeDamage(playerDamage);
                    Console.ReadLine();

                    monsterDamage = Enemy.MonsterAttack();
                    Player.TakeDamage(monsterDamage);
                    Console.ReadLine();
                    if (Enemy.Hitpoints <= 0)
                    {
                        killCount++;
                        if (Enemy.ChanceToDropLoot())
                        {
                            Player.PickupWeapon(Enemy.DropWeapon());
                        }
                    }

                }
                Console.ReadLine();
                Console.Clear();
            }
            //Had naar een game over functie kunnen gaan
            this._logger.DisplayMessage("The story ends, GIT always wins.");
            this._logger.DisplayMessage($"Total damage dealt: {totalDamage}.");
            this._logger.DisplayMessage($"Enemies killed: {killCount}.");
            Console.ReadLine();

        }
    }
}
