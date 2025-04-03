using System;

public class Class19
{
    public static void Task19()
    {
        int[][] numbers = {
            new int[] { 10, 34, 65 },
            new int[] { 76, 18, 55 },
            new int[] { 81, 75, 20 }
        };

        int binaryNumber = Convert.ToInt32("1101011", 2); 

        foreach (var set in numbers)
        {
            Console.WriteLine($"Числа {set[0]}, {set[1]}, {set[2]} больше {binaryNumber}:");
            foreach (var num in set)
            {
                if (num > binaryNumber)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}