using System;

internal class Program
{
    public static void Main(string[] args)
    {
        //Welcome!!!! yeet 
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int numRolls = int.Parse(Console.ReadLine());
        
        //Create Dice Roller object
        DiceRoller diceRoller = new DiceRoller();
        //second diceRoller is an instance from the class DiceRoller file
        
        // Call the simulator and get results array
        int[] results = diceRoller.RollDice(numRolls);
        

        // Print header
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        
        // Print histogram for sums 2–12
        for (int total = 2; total <= 12; total++)
        {
            int count = results[total];

            // Calculate percentage
            double percentage = (count / (double)numRolls) * 100;

            // Convert to stars (rounded)
            int stars = (int)Math.Round(percentage);

            Console.Write($"{total}: ");
            Console.WriteLine(new string('*', stars));
        }

        
        // Goodbye message
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}