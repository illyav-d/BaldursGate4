using GitGate4.GameControl;
using Microsoft.Extensions.DependencyInjection;

namespace GitGate4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Oude manier VOOR we service deden
            //Variables
            //Random random = new Random();
            //IWeapon dagger = new Dagger();
            //IDice dice = new CustomDice(random);
            //IConsoleLogger logger = new ConsoleLogger();
            //IWeaponCreator weaponCreator = new WeaponCreator();
            //IEnemyCreator enemyCreator = new EnemyCreator(logger, random, weaponCreator);
            //ICharacterCreator characterCreator = new CharacterCreator(dice, logger, dagger);
            //IGame game = new Game(logger, characterCreator, enemyCreator);


            //Met Service (je kan makkelijker aanpassen, meer parameters in gamestate enz)

            ServiceCollection services = new ServiceCollection();
            StartupConfig config = new StartupConfig();
            services = config.configureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            IGame game = serviceProvider.GetService<IGame>();



            // Race + Char
            game.CharacterCreation();

            //Display
            game.StoryTelling();

            //Progression
            game.EventProgression();
        }
    }
}
