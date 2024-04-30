namespace GitGate4.Player
{
    public class Elf : PlayerCharacter
    {
        public Elf()
        {
            Hitpoints = dice.RollTheDices(3).Sum();
            Intelligence = dice.RollTheDices(4).Sum();
            Strength = dice.RollTheDices(1).Sum();
            Weapon.PrimaryAttribute = "Intelligence";
        }
    }
}
