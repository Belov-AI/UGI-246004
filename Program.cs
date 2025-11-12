using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        int minDigit = 10, position = 0, minPos = 0, currPos = 1;
        int temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit < minDigit)
            {
                minDigit = digit;
                minPos = currPos;
            }
            temp /= 10;
            currPos++;
        }
        Console.WriteLine($"Позиция минимальной цифры (справа налево): {minPos}");
    }
}
