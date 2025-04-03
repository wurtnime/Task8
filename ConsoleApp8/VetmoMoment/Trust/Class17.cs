using System;

public class Class17
{
    public static void Task17()
    {
        double[][] numbers = {
            new double[] { -13, -3.5 },
            new double[] { 5.8, 37 },
            new double[] { 8, -15 }
        };

        foreach (var set in numbers)
        {
            double[] result = ProcessNumbers(set[0], set[1]);
            Console.WriteLine($"Результат для чисел {set[0]}, {set[1]}: {result[0]}, {result[1]}.");
        }
    }

    private static double[] ProcessNumbers(double a, double b)
    {
        if (Math.Sign(a) != Math.Sign(b))
        {
            return new double[] { -a, -b };
        }
        else
        {
            return new double[] { 0, 0 };
        }
    }
}