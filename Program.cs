using Mission2Assignment;

internal class Program
{
    // private/public = whether or not the method can be called outside the class
    // static only applies to the class (the mold) while leaving static off applies to the instances of that class (statues made by the mold)
    // void/string/int/bool = what is going to be coming out of this method
    private static int Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        int numRolls = int.Parse(Console.ReadLine());

        // Create an instance of the Randomizer class
        Randomizer randomizerInstance = new Randomizer();
        // Call the RollDice method and store the results
        int[] results = randomizerInstance.RollDice(numRolls);

        int[] frequencies = new int[13];
        foreach (int result in results)
        {
            frequencies[result]++;
        }

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("\nTotal number of rolls = " + numRolls.ToString() + ".\n");

        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)frequencies[i] / numRolls * 100;
            int asterisks = (int)Math.Round(percentage);

            Console.Write($"{i}: ");
            for (int j = 0; j < asterisks; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        Console.ReadLine();
        return 0;
    }
}
