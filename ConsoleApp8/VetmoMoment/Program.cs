using System;

// made in Daria Minetova, а так же при поддержке ООО <<Чуть не подавился креатином>> f
class Program
{
    static void Main()
    {
        Console.WriteLine("Практическая №8");
        Console.WriteLine("Введите номер задания 1-30:");
        int taskNumber = int.Parse(Console.ReadLine());

        switch (taskNumber)
        {
            case 1:
                Class1.Task1();
                break;
            case 2:
                Class2.Task2();
                break;
            case 3:
                Class3.Task3();
                break;
            case 4:
                Class4.Task4();
                break;
            case 5:
                Class5.Task5();
                break;
            case 6:
                Class6.Task6();
                break;
            case 7:
                Class7.Task7();
                break;
            case 8:
                Class8.Task8();
                break;
            case 9:
                Class9.Task9();
                break;
            case 10:
                Class10.Task10();
                break;
            case 11:
                Class11.Task11();
                break;
            case 12:
                Class12.Task12();
                break;
            case 13:
                Class13.Task13();
                break;
            case 14:
                Class14.Task14();
                break;
            case 15:
                Class15.Task15();
                break;
            case 16:
                Class16.Task16();
                break;
            case 17:
                Class17.Task17();
                break;
            case 18:
                Class18.Task18();
                break;
            case 19:
                Class19.Task19();
                break;
            case 20:
                Class20.Task20();
                break;
            case 21:
                Class21.Task21();
                break;
            case 22:
                Class22.Task22();
                break;
            case 23:
                Class23.Task23();
                break;
            case 24:
                Class24.Task24();
                break;
            case 25:
                Class25.Task25();
                break;
            case 26:
                Class26.Task26();
                break;
            case 27:
                Class27.Task27();
                break;
            case 28:
                Class28.Task28();
                break;
            case 29:
                Class29.Task29();
                break;
            case 30:
                Class30.Task30();
                break;
            default:
                Console.WriteLine("Неверный номер задания. Введите число от 1 до 30.");
                break;
        }
    }
}