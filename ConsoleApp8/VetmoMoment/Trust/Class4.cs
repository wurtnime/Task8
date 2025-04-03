using System;

public class Class4
{
    public static void Task4()
    {
        double[][] sides = {
            new double[] { 3, 3.5, -2.1 },
            new double[] { 21, -6.55, 0.1 },
            new double[] { -9, -3.7, -0.1 }
        };

        foreach (var side in sides)
        {
            string result = IsRightTriangle(side[0], side[1], side[2]);
            Console.WriteLine($"Треугольник со сторонами {side[0]}, {side[1]}, {side[2]} {result}.");
        }
    }

    private static string IsRightTriangle(double a, double b, double c)
    {
        double[] sides = { a, b, c };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2) ? "прямоугольный" : "не прямоугольный";
    }
}