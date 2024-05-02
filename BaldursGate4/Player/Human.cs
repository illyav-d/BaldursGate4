using GitGate4.Dice;
using GitGate4.Logger;
using GitGate4.Weapon;

namespace GitGate4.Player
{
    public class Human : PlayerCharacter
    {
        public Human(IDice dice, IConsoleLogger consoleLogger, IWeapon dagger) : base(dice, consoleLogger, dagger)
        {
            //TODO: Constructor dice gebruiken of _dice (uit main klasse)?
            Hitpoints = _dice.RollTheDices(3).Sum();
            Intelligence = _dice.RollTheDices().Sum();
            Strength = _dice.RollTheDices().Sum();
        }
    }
}
