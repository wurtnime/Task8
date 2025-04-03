using System;

public class Class22
{
    public static void Task22()
    {
        int[][] numbers = {
            new int[] { 56, 38 },
            new int[] { 47, 91 },
            new int[] { 29, 76 },
            new int[] { 19, 53 }
        };

        foreach (var set in numbers)
        {
            int sum = SumOfDigits(set[0]) + SumOfDigits(set[1]);
            Console.WriteLine($"Сумма цифр чисел {set[0]} и {set[1]} равна {sum}.");
        }
    }

    private static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}