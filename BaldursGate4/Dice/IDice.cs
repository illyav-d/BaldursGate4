
namespace GitGate4.Dice
{
    public interface IDice
    {
        Random myRandom { get; set; }

        int RollStat(int diceRolls, Random myRandom);
        public int[] RollTheDices(int amount = 2);
        public int rollDice(Random random);
    }
}