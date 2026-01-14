using System;

class DiceRoller
{
    public int[] RollDice(int numRolls)
    {
        // Array to hold results for totals 2–12
        // Index = dice total
        int[] results = new int[13];

        Random random = new Random();

        for (int i = 0; i < numRolls; i++)
        {
            int die1 = random.Next(1, 7); // 1–6
            int die2 = random.Next(1, 7); // 1–6

            int sum = die1 + die2;

            results[sum]++;
        }

        return results;
    }
}