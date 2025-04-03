using System;

public class Class12
{
    public static void Task12()
    {
        double[][] numbers = {
            new double[] { 45, 13, -23 },
            new double[] { -31, 65, 12 },
            new double[] { 52, -1, -33 }
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