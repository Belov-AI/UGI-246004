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
            var x = Calculate(2, 2) + Calculate(5, 3) + Calculate(11, 5);
            Console.WriteLine(Math.Round(x, 3));
        }

        static double Calculate(double a, double b) =>
            Math.Sqrt((1 + Math.Sqrt(a)) / b);

    }
}
