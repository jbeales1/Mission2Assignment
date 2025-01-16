using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    public class Randomizer
    {
        // Method to simulate rolling of dice a specified number of times
        public int[] RollDice(int numRolls)
        {
            // Create a Random object to generate random numbers
            Random randomRoll = new Random();
            // Create an array to store the results of each dice roll
            int[] results = new int[numRolls];

            // Loop through the number of rolls specified by the user
            for (int i = 0; i < numRolls; i++)
            {
                // Simulate rolling two 6-sided dice and summing the results
                int rollResult = randomRoll.Next(1, 7) + randomRoll.Next(1, 7);
                // Store the result in the results array
                results[i] = rollResult;
            }
            // Return the array containing the results of all dice rolls
            return results;
        }
    }
}
