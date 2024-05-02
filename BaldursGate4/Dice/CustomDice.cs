namespace GitGate4.Dice
{
    public class CustomDice : IDice
    {

        public CustomDice(Random random)
        {
            myRandom = random;
        }
        public Random myRandom { get; set; }



        //Kan de rolls niet checken
        public int RollStat(int diceRolls, Random myRandom)
        {
            int statTotal = 0;


            for (int i = 0; i < diceRolls; i++)
            {
                statTotal += myRandom.Next(1, 7);
            }
            return statTotal;
        }

        //Kan de rolls checken maar arrays niet leuk..
        public int rollDice(Random random)
        {
            return random.Next(1, 7);
        }

        public int[] RollTheDices(int amount = 2)
        {
            var result = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                result[i] = rollDice(myRandom);
            }

            return result;
        }
    }
}
