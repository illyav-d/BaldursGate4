using GitGate4.Player;

namespace GitGate4.Factory
{
    internal class CharacterCreator : ICharacterCreator
    {
        public IPlayer Create(Races Race)
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
