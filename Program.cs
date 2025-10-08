using System;

class Program
{
    static void Main()
    {
        double x = F(2, 3) + F(5, 7) + F(4, 6);
        Console.WriteLine($"x = {x:F3}");
    }

    static double F(double a, double b)
    {
        return (Math.Exp(a) - Math.Exp(-a)) / (Math.Exp(b) + Math.Exp(-b));
    }
}