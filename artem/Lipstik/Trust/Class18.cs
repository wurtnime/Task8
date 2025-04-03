using System;

public class Class18
{
    public static void Task18()
    {
        double[][] numbers = {
            new double[] { 15, 13, -33 },
            new double[] { -38, 25, 12 },
            new double[] { 22, -1, -33 }
        };

        foreach (var set in numbers)
        {
            double result = FindMinValue(set[0], set[1], set[2]);
            Console.WriteLine($"Наименьшее значение для чисел {set[0]}, {set[1]}, {set[2]} равно {result}.");
        }
    }

    private static double FindMinValue(double a, double b, double c)
    {
        return Math.Min(a, Math.Min(b, c));
    }
}