using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class DiceGame
    {
        private int diceThrow;
        public string Feedback
        {
            get
            {
                if (diceThrow != 7)
                    return "You Loose!";
                else
                    return "You win!";
            }
        }

    }
}
