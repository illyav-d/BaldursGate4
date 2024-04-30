namespace GitGate4.Player
{
    public class Human : PlayerCharacter
    {
        public Human()
        {
            Hitpoints = dice.RollTheDices(3).Sum();
            Intelligence = dice.RollTheDices().Sum();
            Strength = dice.RollTheDices().Sum();
        }
    }
}
