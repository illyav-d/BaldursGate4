namespace GitGate4.Dice
{
    public class CustomDice : IDice
    {
        Random _random = new Random();
        public CustomDice()
        {

        }



        //Kan de rolls niet checken
        public int RollStat(int diceRolls)
        {
            int statTotal = 0;


            for (int i = 0; i < diceRolls; i++)
            {
                statTotal += _random.Next(1, 7);
            }
            return statTotal;
        }

        //Kan de rolls checken maar arrays niet leuk..
        public int rollDice()
        {
            return _random.Next(1, 7);
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
