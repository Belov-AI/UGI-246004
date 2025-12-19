using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для вычисления функции y = f(x)");
        Console.WriteLine("Функция: y = sin((3.2 + √(x + 1)) / |5x|)");

        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = CalculateFunction(x);
            Console.WriteLine($"f({x}) = {result:F6}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректное числовое значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при вычислении: {ex.Message}");
        }
    }

    static double CalculateFunction(double x)
    {
        
        if (x == 0)
        {
            throw new ArgumentException("x не может быть равен 0 (деление на ноль)");
        }

        
        if (x < -1)
        {
            throw new ArgumentException("x не может быть меньше -1 (отрицательное значение под корнем)");
        }

       
        double numerator = 3.2 + Math.Sqrt(x + 1);
        double denominator = Math.Abs(5 * x);
        double argument = numerator / denominator;

       
        return Math.Sin(argument);
    }
}