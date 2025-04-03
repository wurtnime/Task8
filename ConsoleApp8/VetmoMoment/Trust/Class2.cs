using System;

public class Class2
{
    public static void Task2()
    {
        double[][] numbers = {
            new double[] { 3, 3.5, -2.1 },
            new double[] { 2.1, -6.55, 0.1 },
            new double[] { -9, -3.7, -0.1 }
        };

        foreach (var set in numbers)
        {
            double result = FindMiddleValue(set[0], set[1], set[2]);
            Console.WriteLine($"Среднее значение для чисел {set[0]}, {set[1]}, {set[2]} равно {result}.");
        }
    }

    private static double FindMiddleValue(double a, double b, double c)
    {
        double max = Math.Max(a, Math.Max(b, c));
        double min = Math.Min(a, Math.Min(b, c));
        return a + b + c - max - min;
    }
}