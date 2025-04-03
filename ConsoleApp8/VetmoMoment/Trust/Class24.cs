using System;

public class Class24
{
    public static void Task24()
    {
        double[][] resistances = {
            new double[] { 5, 10, 2 },
            new double[] { 3, 5, 7 },
            new double[] { 4, 6, 8 }
        };

        foreach (var set in resistances)
        {
            double series = SeriesResistance(set[0], set[1], set[2]);
            double parallel = ParallelResistance(set[0], set[1], set[2]);
            Console.WriteLine($"Для сопротивлений {set[0]}, {set[1]}, {set[2]}: последовательное = {series}, параллельное = {parallel}.");
        }
    }

    private static double SeriesResistance(double r1, double r2, double r3)
    {
        return r1 + r2 + r3;
    }

    private static double ParallelResistance(double r1, double r2, double r3)
    {
        return 1 / (1 / r1 + 1 / r2 + 1 / r3);
    }
}