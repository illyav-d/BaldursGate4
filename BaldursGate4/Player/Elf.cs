namespace BaldursGate4.Player
{
    public class Elf : PlayerCharacter
    {
        public Elf()
        {
            Hitpoints = dice.RollTheDices().Sum();
            Intelligence = dice.RollTheDices().Sum();
            Strength = dice.RollTheDices().Sum();
        }
    }
}
