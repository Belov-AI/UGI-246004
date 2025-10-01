using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1000 || number > 9999)
                throw new ArgumentException("Число должно быть четырехзначным!");

            int result = (number / 1000) * 1000 +
                        ((number / 10) % 10) * 100 +
                        ((number / 100) % 10) * 10 +
                        (number % 10);

            Console.WriteLine($"Исходное число: {number}");
            Console.WriteLine($"После перестановки: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}