using System;

public class Class20
{
    public static void Task20()
    {
        int[][] numbers = {
            new int[] { 10, 34, 65 },
            new int[] { 76, 5, 55 },
            new int[] { 11, 75, 20 }
        };

        foreach (var set in numbers)
        {
            int max = FindMaxValue(set[0], set[1], set[2]);
            Console.WriteLine($"Наибольшее значение для чисел {set[0]}, {set[1]}, {set[2]} равно {max}.");
        }
    }

    private static int FindMaxValue(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}