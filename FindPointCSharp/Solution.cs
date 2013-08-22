using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int numberOfPoints = ReadNumberOfPoints();

        // if we recieve a -1 for the number of points, then we know an error
        // occurred
        if (numberOfPoints == -1)
        {
            return;
        }
    }

    static int ReadNumberOfPoints()
    {
        int numberOfPoints = -1;
        String line = Console.ReadLine();

        // ensure that the value read in can be converted to an int32, and if
        // it can't, then catch the FormatException thrown and let the user
        // know what incorrect value was typed.
        try
        {
            numberOfPoints = Convert.ToInt32(line);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input: '" + line + "' not an integer");
        }

        return numberOfPoints;
    }
}
