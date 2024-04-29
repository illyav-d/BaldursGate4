namespace BaldursGate4.Player
{
    public class Dwarf : PlayerCharacter
    {
        public Dwarf()
        {
            Hitpoints = dice.RollTheDices().Sum();
            Intelligence = dice.RollTheDices(1).Sum();
            Strength = dice.RollTheDices(4).Sum();
        }
    }
}
