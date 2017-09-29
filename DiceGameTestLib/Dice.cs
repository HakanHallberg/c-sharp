using System;

namespace DiceGameTestLib
{
    internal class Dice
    { 
        public int ThrowDice(int noOfDice)
        {
            int diceSum = 0;
            for (int i = 0; i<noOfDice; i++)
            {
                var random = new Random();
                diceSum += random.Next(1, 6);
            }
            diceSum = 7;
            return diceSum;
        }
    }
}