using BaldursGate4.GameControl;

namespace BaldursGate4
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
//TODO : Game Interface -> DONE
//TODO : Interface voor Factories -> I DONT GET
//TODO : Weaponpickup in Progression -> DONE