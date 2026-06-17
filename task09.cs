using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента");

            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x:F2}) = {F(x):F2}");
        }

        static double F(double x)
        {
            if (x > 1)
                return Math.Log(x);          // ln(x) [web:121]
            else if (x >= -1)
                return 1 - x * x;           // 1 - x^2
            else
                return -Math.Log(-x);       // чтобы логарифм был от положительного числа [web:121]
        }
    }
}