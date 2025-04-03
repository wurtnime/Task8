using System;

public class Class10
{
    public static void Task10()
    {
        int[] themes = { 1, 2, 3 };
        char[] variants = { 'a', 'b', 'c' };

        foreach (var theme in themes)
        {
            foreach (var variant in variants)
            {
                string result = GetGreetingCard(theme, variant);
                Console.WriteLine(result);
            }
        }
    }

    private static string GetGreetingCard(int theme, char variant)
    {
        string themeName = theme switch
        {
            1 => "Новогодние",
            2 => "С Днем Рождения",
            3 => "С Днем Защитника Отечества",
            _ => "Неизвестная тема"
        };

        return $"{themeName}, вариант {variant}";
    }
}