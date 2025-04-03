using System;

public class Class16
{
    public static void Task16()
    {
        double[][] sides = {
            new double[] { 3, 3.5, 1.5 },
            new double[] { 3, 6.55, 6.55 },
            new double[] { 0.9, 0.9, 0.9 }
        };

        foreach (var side in sides)
        {
            string result = DetermineTriangleType(side[0], side[1], side[2]);
            Console.WriteLine($"Треугольник со сторонами {side[0]}, {side[1]}, {side[2]} является {result}.");
        }
    }

    private static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "равносторонним";
        else if (a == b || b == c || a == c)
            return "равнобедренным";
        else
            return "простым";
    }
}