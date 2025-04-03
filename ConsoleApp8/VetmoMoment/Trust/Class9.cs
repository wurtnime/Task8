using System;

public class Class9
{
    public static void Task9()
    {
        double[][] rates = {
            new double[] { 0.5, 0.1 },
            new double[] { 0.45, 0.08 },
            new double[] { 0.55, 0.12 }
        };

        foreach (var rate in rates)
        {
            double cost = CalculateCallCost(rate[0], rate[1], 100, 50); 
            Console.WriteLine($"Стоимость разговоров: {cost} руб.");
        }
    }

    private static double CalculateCallCost(double rate, double discount, double weekdayMinutes, double weekendMinutes)
    {
        double weekdayCost = weekdayMinutes * rate;
        double weekendCost = weekendMinutes * rate * (1 - discount);
        return weekdayCost + weekendCost;
    }
}