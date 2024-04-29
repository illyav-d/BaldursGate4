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

            //Weapons
            var weaponsCount = Enum.GetNames(typeof(Weapons)).Length + 1;
            Weapons weaponName = (Weapons)random.Next(1, weaponsCount);
            WeaponCreator weaponCreator = new WeaponCreator();
            IWeapon weapon = weaponCreator.createAWeapon(weaponName);

            //Display
            logger.DisplayMessage("Our journey begins in the Darkest Dungeons of GIT, you only have a dagger and a gitbash manual");
            logger.DisplayMessage($"You are a {raceName}.");
            Console.ReadLine();
            player.DisplayStats();
            Console.ReadLine();
            logger.DisplayMessage($"You find a {weaponName}.");
            player.PickupWeapon(weapon, weaponName);


        }
    }
}
