using GitGate4.GameControl;

namespace GitGate4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            IGame game = new Game();

            // Race + Char
            game.CharacterCreation();

            //Display
            game.StoryTelling();

            //Progression
            game.EventProgression();
        }
    }
}
