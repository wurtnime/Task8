using System;

public class Class23
{
    public static void Task23()
    {
        int[][] numbers = {
            new int[] { 46, 78 },
            new int[] { 41, 81 },
            new int[] { 39, 76 },
            new int[] { 29, 53 }
        };

        foreach (var set in numbers)
        {
            int product = ProductOfDigits(set[0]) * ProductOfDigits(set[1]);
            Console.WriteLine($"Произведение цифр чисел {set[0]} и {set[1]} равно {product}.");
        }
    }

    private static int ProductOfDigits(int number)
    {
        int product = 1;
        while (number != 0)
        {
            product *= number % 10;
            number /= 10;
        }
        return product;
    }
}