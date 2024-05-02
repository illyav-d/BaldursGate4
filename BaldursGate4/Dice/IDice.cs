
namespace GitGate4.Dice
{
    public interface IDice
    {


        int RollStat(int diceRolls);
        public int[] RollTheDices(int amount = 2);
        public int rollDice();
    }
}