namespace BaldursGate4.Player
{
    public class Human : PlayerCharacter
    {
        public Human()
        {
            Hitpoints = dice.RollTheDices().Sum();
            Intelligence = dice.RollTheDices().Sum();
            Strength = dice.RollTheDices().Sum();
        }
    }
}
