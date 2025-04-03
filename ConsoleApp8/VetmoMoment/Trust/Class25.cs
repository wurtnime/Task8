using System;

public class Class25
{
    public static void Task25()
    {
        double[] resistances = { 6, 30, 800 };
        double[] currents = { 2, 4, 0.6 };
        double sourceVoltage = 45;

        for (int i = 0; i < resistances.Length; i++)
        {
            double voltageDrop = resistances[i] * currents[i];
            if (voltageDrop <= sourceVoltage)
            {
                Console.WriteLine($"Резистор {resistances[i]} Ом и ток {currents[i]} А подходят для источника {sourceVoltage} В.");
            }
            else
            {
                Console.WriteLine($"Резистор {resistances[i]} Ом и ток {currents[i]} А не подходят для источника {sourceVoltage} В.");
            }
        }
    }
}