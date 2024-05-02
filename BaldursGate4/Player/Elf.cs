using GitGate4.Dice;
using GitGate4.Logger;
using GitGate4.Weapon;

namespace GitGate4.Player
{
    public class Elf : PlayerCharacter
    {
        public Elf()
        {
            
        }

        public Elf(IDice dice, IConsoleLogger consoleLogger, IWeapon dagger) : base(dice, consoleLogger, dagger)
        {
            Hitpoints = dice.RollTheDices(3).Sum();
            Intelligence = dice.RollTheDices(4).Sum();
            Strength = dice.RollTheDices(1).Sum();
            Weapon.PrimaryAttribute = "Intelligence";
        }

        public void HealSelf(int healValue)
        {
            this.Hitpoints += healValue;
        }
    }
}
