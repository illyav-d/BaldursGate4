using BaldursGate4.Player;

namespace BaldursGate4.Factory
{
    internal class CharacterCreator
    {
        public IPlayer createACharacter(Races Race)
        {
            switch (Race)
            {
                case Races.Human:
                    return new Human();

                case Races.Dwarf:
                    return new Dwarf();

                case Races.Elf:
                    return new Elf();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
