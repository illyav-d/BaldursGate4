using GitGate4.Player;

namespace GitGate4.Factory
{
    public interface ICharacterCreator
    {
        IPlayer Create(Races Race);
    }
}