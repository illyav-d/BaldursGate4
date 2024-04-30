using GitGate4.Player;

namespace GitGate4.Factory
{
    internal interface ICharacterCreator
    {
        IPlayer Create(Races Race);
    }
}