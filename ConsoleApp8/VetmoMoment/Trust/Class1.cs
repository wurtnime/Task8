using System;

public class Class1
{
    public static void Task1()
    {
        double[] xValues = { 3.5, -0.5, 0.72 };
        double[] yValues = { 7.2, 1.2, -3.12 };

        for (int i = 0; i < xValues.Length; i++)
        {
            bool result = IsPointInArea(xValues[i], yValues[i]);
            Console.WriteLine($"Точка A({xValues[i]}, {yValues[i]}) {(result ? "лежит" : "не лежит")} в области.");
        }
    }

    private static bool IsPointInArea(double x, double y)
    {
        double parabolalY = 2 - x * x;
        return y >= 0 && y <= parabolalY;
    }
}