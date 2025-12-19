using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число");

            var x = double.Parse(Console.ReadLine());
            var y = F(x);

            Console.WriteLine("y = " + y);
        }

        static double F(double x)
        {
            var numerator = 3 - 2 * Math.Sin(x / 2.0);
            var denominator = 1 + Math.Pow(Math.Cos(x), 4);

            return Math.Sqrt(numerator / denominator);
        }
    }
}