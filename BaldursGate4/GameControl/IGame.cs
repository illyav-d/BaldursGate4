using GitGate4.Player;

namespace GitGate4.GameControl
{
    public interface IGame
    {
        IPlayer Player { get; set; }
        Races RaceName { get; set; }

        void CharacterCreation();
        void EventProgression();
        void StoryTelling();
    }
}