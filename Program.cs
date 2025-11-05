using System;

class Program
{
    static double CalculateF(double x)
    {
        if (x < -1)
        {
            return 1 - Math.Pow(x, 2);
        }
        else if (x >= -1 && x <= 1)
        {
            return 0;
        }
        else 
        {
            return x - 1;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = CalculateF(x);
        Console.WriteLine($"f({x}) = {result}");
    }
}