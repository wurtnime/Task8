using System;

public class Class21
{
    public static void Task21()
    {
        string[][] numbers = {
            new string[] { "A", "22", "41" },
            new string[] { "4C", "5", "37" },
            new string[] { "B", "4B", "14" }
        };

        foreach (var set in numbers)
        {
            int min = FindMinValue(set[0], set[1], set[2]);
            Console.WriteLine($"Наименьшее значение для чисел {set[0]}, {set[1]}, {set[2]} равно {min}.");
        }
    }

    private static int FindMinValue(string a, string b, string c)
    {
        int numA = Convert.ToInt32(a, 16);
        int numB = Convert.ToInt32(b, 16);
        int numC = Convert.ToInt32(c, 16);
        return Math.Min(numA, Math.Min(numB, numC));
    }
}