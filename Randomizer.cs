using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    public class Randomizer
    {
        public int[] RollDice(int numRolls)
        {
            Random randomRoll = new Random();
            int[] results = new int[numRolls];

            for (int i = 0; i < numRolls; i++)
            {
                int rollResult = randomRoll.Next(1, 7) + randomRoll.Next(1, 7);
                results[i] = rollResult;
            }

            return results;
        }
    }
}
