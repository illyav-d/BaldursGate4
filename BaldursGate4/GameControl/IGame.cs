using BaldursGate4.Player;

namespace BaldursGate4.GameControl
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