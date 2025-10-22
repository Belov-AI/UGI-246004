using System;

class Program
{

    static bool CheckCondition(int n)
    {
        return (n % 2 != 0) && (n % 3 != 0);
    }


    static bool IsPointInArea(double x, double y)
    {
        return (y >= 0.5) && (y <= 1.5);
    }

    static void Main()
    {
        Console.WriteLine("Задача 8.1");

     
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число k: ");
        int k = int.Parse(Console.ReadLine());

        bool result = CheckCondition(n);
        Console.WriteLine($"Число n = {n} не кратно ни 2, ни 3: {result}");

        Console.WriteLine("\n=== Задача 8.2 ===");

        Console.Write("Введите координату x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату y: ");
        double y = double.Parse(Console.ReadLine());

        bool inArea = IsPointInArea(x, y);
        Console.WriteLine($"Точка ({x}, {y}) принадлежит области: {inArea}");
    }
}