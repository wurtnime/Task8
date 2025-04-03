using System;

public class Class6
{
    public static void Task6()
    {
        double[][] numbers = {
            new double[] { -3, 3.5, 0.1 },
            new double[] { 58, 27, -87 },
            new double[] { -8, -35, 42 }
        };

        foreach (var set in numbers)
        {
            double[] result = ProcessNumbers(set[0], set[1], set[2]);
            Console.WriteLine($"Результат для чисел {set[0]}, {set[1]}, {set[2]}: {result[0]}, {result[1]}, {result[2]}.");
        }
    }

    private static double[] ProcessNumbers(double a, double b, double c)
    {
        if (a + b + c > 0)
        {
            return new double[] { a * 2, b * 2, c * 2 };
        }
        else
        {
            return new double[] { 0, 0, 0 };
        }
    }
}