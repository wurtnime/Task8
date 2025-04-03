using System;

public class Class14
{
    public static void Task14()
    {
        double[][] points = {
            new double[] { 2.2, -6 },
            new double[] { 0.3, 3 }
        };

        foreach (var point in points)
        {
            bool result = IsPointOnCurve(point[0], point[1]);
            Console.WriteLine($"Точка ({point[0]}, {point[1]}) {(result ? "лежит" : "не лежит")} на кривой.");
        }
    }

    private static bool IsPointOnCurve(double x, double y)
    {
        double curveY = x <= 2 ? Math.Pow(x, 2.1) : 4;
        return Math.Abs(curveY - y) < 0.001; // Учитываем погрешность
    }
}