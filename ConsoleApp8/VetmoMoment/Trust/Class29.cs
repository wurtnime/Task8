using System;

public class Class29
{
    public static void Task29()
    {
        double[] xValues = { 2, -0.5, 1.5 };
        double[] yValues = { 1.5, 2.3, -0.8 };
        double radius = 2.5;

        for (int i = 0; i < xValues.Length; i++)
        {
            bool result = IsPointInCircle(xValues[i], yValues[i], radius);
            Console.WriteLine($"Точка ({xValues[i]}, {yValues[i]}) {(result ? "лежит" : "не лежит")} внутри окружности.");
        }
    }

    private static bool IsPointInCircle(double x, double y, double radius)
    {
        double distance = Math.Sqrt(x * x + y * y);
        return distance <= radius;
    }
}