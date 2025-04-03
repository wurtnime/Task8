using System;

public class Class8
{
    public static void Task8()
    {
        double[][] sides = {
            new double[] { 3, 3.5, 1.1 },
            new double[] { 3, 6.55, 6.55 },
            new double[] { 0.9, 0.9, 0.9 }
        };

        foreach (var side in sides)
        {
            string result = IsIsoscelesTriangle(side[0], side[1], side[2]);
            Console.WriteLine($"Треугольник со сторонами {side[0]}, {side[1]}, {side[2]} {result}.");
        }
    }

    private static string IsIsoscelesTriangle(double a, double b, double c)
    {
        if (a == b || b == c || a == c)
            return "равнобедренный";
        else
            return "не равнобедренный";
    }
}