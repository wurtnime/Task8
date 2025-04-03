using System;

public class Class15
{
    public static void Task15()
    {
        double[][] points = {
            new double[] { 30, 121 },
            new double[] { -15, 50 },
            new double[] { 87, 223 }
        };

        foreach (var point in points)
        {
            string hemisphere = DetermineHemisphere(point[0], point[1]);
            Console.WriteLine($"Точка с координатами ({point[0]}, {point[1]}) находится в {hemisphere}.");
        }
    }

    private static string DetermineHemisphere(double latitude, double longitude)
    {
        string northSouth = latitude >= 0 ? "северном" : "южном";
        string eastWest = longitude >= 0 ? "восточном" : "западном";
        return $"{northSouth} полушарии и {eastWest} полушарии";
    }
}