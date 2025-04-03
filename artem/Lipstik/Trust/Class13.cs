using System;

public class Class13
{
    public static void Task13()
    {
        double[][] numbers = {
            new double[] { 3.2, -7, 0.5 },
            new double[] { 2.3, 3, 2.5 },
            new double[] { 23, -34, 89.5 }
        };

        foreach (var set in numbers)
        {
            double average = (set[0] + set[1] + set[2]) / 3;
            Console.WriteLine($"Среднее арифметическое для чисел {set[0]}, {set[1]}, {set[2]} равно {average}.");
            Console.WriteLine("Числа, большие среднего:");
            foreach (var num in set)
            {
                if (Math.Abs(num) > average)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}