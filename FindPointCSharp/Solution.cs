using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    private const int MinimumNumberOfPoints = 1;
    private const int MaximumNumberOfPoints = 15;

    static void Main(String[] args)
    {
        int numberOfTestCases = ReadNumberOfTestCases();

        // if we recieve a -1 for the number of points, then we know an error
        // occurred
        if (numberOfTestCases < 0)
        {
            return;
        }
    }

    static int ReadNumberOfTestCases()
    {
        int numberOfTestCases;
        String line = Console.ReadLine();

        // ensure that the value read in can be converted to an int32, and if
        // it can't, then catch the FormatException thrown and let the user
        // know what incorrect value was typed.
        try
        {
            numberOfTestCases = Convert.ToInt32(line);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input: '" + line + "' not an integer");
            return -1;
        }

        if (numberOfTestCases < MinimumNumberOfPoints ||
            numberOfTestCases > MaximumNumberOfPoints)
        {
            Console.WriteLine("Invalid Input: " + numberOfTestCases +
                " is not in range (" + MinimumNumberOfPoints + " <= T <= " +
                MaximumNumberOfPoints + ")");
            return -2;
        }

        return numberOfTestCases;
    }
}
