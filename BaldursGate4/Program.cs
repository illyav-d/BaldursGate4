using GitGate4.Dice;
using GitGate4.Factory;
using GitGate4.GameControl;
using GitGate4.Logger;
using GitGate4.Weapon;

namespace GitGate4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Random random = new Random();
            IWeapon dagger = new Dagger();
            IDice dice = new CustomDice(random);
            IConsoleLogger logger = new ConsoleLogger();
            IWeaponCreator weaponCreator = new WeaponCreator();
            IEnemyCreator enemyCreator = new EnemyCreator(logger, random, weaponCreator);
            ICharacterCreator characterCreator = new CharacterCreator(dice, logger, dagger);
            IGame game = new Game(random, logger, characterCreator, enemyCreator);

            // Race + Char
            game.CharacterCreation(characterCreator);

            //Display
            game.StoryTelling(logger);

            //Progression
            game.EventProgression(enemyCreator, logger);
        }
    }
}
