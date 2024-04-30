namespace GitGate4.Dice
{
    public class Dice : IDice
    {
        public Random myRandom { get; set; }

        //Kan de rolls niet checken
        public int RollStat(int diceRolls)
        {
            int statTotal = 0;
            myRandom = new Random();

            for (int i = 0; i < diceRolls; i++)
            {
                statTotal += myRandom.Next(1, 7);
            }
            return statTotal;
        }

        //Kan de rolls checken maar arrays niet leuk..
        public int rollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public int[] RollTheDices(int amount = 2)
        {
            var result = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                result[i] = rollDice();
            }

            return result;
        }
    }
}
