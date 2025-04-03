using System;

public class Class27
{
    public static void Task27()
    {
        double[][] points = {
            new double[] { 3.5, 7.2 },
            new double[] { -0.5, 1.2 },
            new double[] { 0.72, -3.12 }
        };

        foreach (var point in points)
        {
            bool result = IsPointInArea(point[0], point[1]);
            Console.WriteLine($"Точка A({point[0]}, {point[1]}) {(result ? "лежит" : "не лежит")} в области.");
        }
    }

    private static bool IsPointInArea(double x, double y)
    {
        double parabolalY = 2 - x * x;
        return y >= 0 && y <= parabolalY;
    }
}