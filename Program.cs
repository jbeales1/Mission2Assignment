// Jonathan Beales - IS 413 - Program that rolls 2 dice and shows what percent of each number was rolled

using Mission2Assignment;

internal class Program
{
    // private/public = whether or not the method can be called outside the class
    // static only applies to the class (the mold) while leaving static off applies to the instances of that class (statues made by the mold)
    // void/string/int/bool = what is going to be coming out of this method
    private static int Main(string[] args)
    {   
        // welcome sentences displayed to the console
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        // storing the number of requested rolls in numRolls
        int numRolls = int.Parse(Console.ReadLine());

        // Create an instance of the Randomizer class
        Randomizer randomizerInstance = new Randomizer();
        // Call the RollDice method and store the results
        int[] results = randomizerInstance.RollDice(numRolls);

        // creating an array of integers names frequencies to store count of each dice roll outcome
        int[] frequencies = new int[13];
        foreach (int result in results)
        {
            // increment the count for each result
            frequencies[result]++;
        }
        // display the results header
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("\nTotal number of rolls = " + numRolls.ToString() + ".\n");
        
        // iterate through possible dice roll outcomes to generate the histogram
        for (int i = 2; i <= 12; i++)
        {
            //calculate the percentage of each outcome
            double percentage = (double)frequencies[i] / numRolls * 100;
            //rounding the percentage to the nearest integer
            int asterisks = (int)Math.Round(percentage);

            // display the outcome number and corresponding asterisks
            Console.Write($"{i}: ");
            // move to the next line after displaying asterisks for the current outcome
            for (int j = 0; j < asterisks; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        //goodbye message
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        Console.ReadLine();
        // returning exit code 0
        return 0;
    }
}
