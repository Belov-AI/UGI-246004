using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x =
                Calculate(3, 7) +
                Calculate(5, 11) +
                Calculate(7, 3) +
                Calculate(11, 5);

            Console.WriteLine(Math.Round(x, 3));
        }

        static double Calculate(double a, double b)
        {
            var numerator = 1 + Math.Pow(Math.Tan(a), 2);
            var denominator = Math.Log(1 + Math.Pow(b, 2)); // ln(1 + b^2) [web:63]

            return numerator / denominator;
        }
    }
}
