using GitGate4.Factory;
using GitGate4.Logger;
using GitGate4.Player;

namespace GitGate4.GameControl
{
    public interface IGame
    {
        IPlayer Player { get; set; }
        Races RaceName { get; set; }

        void CharacterCreation(ICharacterCreator creator);
        void EventProgression(IEnemyCreator enemyCreator, IConsoleLogger logger);
        void StoryTelling(IConsoleLogger logger);
    }
}