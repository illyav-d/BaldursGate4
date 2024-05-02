using GitGate4.Dice;
using GitGate4.Logger;
using GitGate4.Player;
using GitGate4.Weapon;

namespace GitGate4.Factory
{
    internal class CharacterCreator : ICharacterCreator
    {
        IDice _dice;
        IConsoleLogger _logger;
        //TODO: Is het ok om dagger te gebruiken ipv Iweapon => Antwoord gevonden, Iweapon is beter, makkelijker aanpasbaar
        IWeapon _defaultweapon;
        public CharacterCreator(IDice dice, IConsoleLogger logger, IWeapon dagger)
        {
            _dice = dice;
            _logger = logger;
            _defaultweapon = dagger;
        }
        public IPlayer Create(Races Race)
        {
            switch (Race)
            {
                case Races.Human:
                    return new Human(_dice, _logger, _defaultweapon);

                case Races.Dwarf:
                    return new Dwarf(_dice, _logger, _defaultweapon);

                case Races.Elf:
                    return new Elf(_dice, _logger, _defaultweapon);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
