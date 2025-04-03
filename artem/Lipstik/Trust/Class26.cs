using System;

public class Class26
{
    public static void Task26()
    {
        int[][] resistances = {
            new int[] { 6, 10, 2 },
            new int[] { 3, 5, 7 },
            new int[] { 4, 12, 8 }
        };

        foreach (var set in resistances)
        {
            bool result = CanObtainResistance(set[0], set[1], set[2]);
            Console.WriteLine($"Можно ли получить сопротивление {set[2]} Ом с помощью резисторов {set[0]} и {set[1]} Ом? {result}");
        }
    }

    private static bool CanObtainResistance(int r1, int r2, int target)
    {
        return target == r1 + r2 || target == 1 / (1.0 / r1 + 1.0 / r2);
    }
}