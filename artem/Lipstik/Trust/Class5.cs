using System;

public class Class5
{
    public static void Task5()
    {
        int[] months = { 3, 6, 12 };
        foreach (var month in months)
        {
            string season = GetSeason(month);
            Console.WriteLine($"Месяц {month} относится к сезону: {season}.");
        }
    }

    private static string GetSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Зима";
            case 3:
            case 4:
            case 5:
                return "Весна";
            case 6:
            case 7:
            case 8:
                return "Лето";
            case 9:
            case 10:
            case 11:
                return "Осень";
            default:
                return "Неверный месяц";
        }
    }
}