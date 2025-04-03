using System;

public class Class7
{
    public static void Task7()
    {
        double[][] points = {
            new double[] { 2, 2, -4, 0 },
            new double[] { 8, 9, 12, 1 },
            new double[] { -3.5, 0.9, 2, 3 }
        };

        foreach (var point in points)
        {
            string result = ClosestToOrigin(point[0], point[1], point[2], point[3]);
            Console.WriteLine($"Точка {result} ближе к началу координат.");
        }
    }

    private static string ClosestToOrigin(double x1, double y1, double x2, double y2)
    {
        double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);

        if (distance1 < distance2)
            return $"A({x1}, {y1})";
        else
            return $"B({x2}, {y2})";
    }
}