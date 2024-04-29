using BaldursGate4.Dice;
using BaldursGate4.Logger;
using BaldursGate4.Weapon;

namespace BaldursGate4.Player
{
    public class PlayerCharacter : IPlayer
    {
        public IDice dice;
        public PlayerCharacter()
        {
            Weapon = new Dagger();
            dice = new Dice.Dice();
        }

        public int Hitpoints { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public IWeapon Weapon { get; set; }

        public void DisplayStats()
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.DisplayMessage($"These are your current stats...{Environment.NewLine}{this.Hitpoints} HP{Environment.NewLine}{this.Strength} STR{Environment.NewLine}{this.Intelligence} INT");
        }
        public void PickupWeapon(IWeapon weapon, Weapons weaponName)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();

            if (this.Intelligence >= weapon.MinIntelligence && this.Strength >= weapon.MinStrength)
            {
                consoleLogger.DisplayMessage($"You equip the {weaponName}.");
                this.Weapon = weapon;
            }
            else
            {
                consoleLogger.DisplayMessage($"You try to equip the weapon but you are either too dumb or weak. You keep your current weapon.");
            }
        }
    }
}
