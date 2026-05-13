using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate double Function(double x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Function f;

            double x = Math.PI / 2;

            f = Math.Sin;
            Console.WriteLine($"{ f(x):F3}");

            f = Math.Cos;
            Console.WriteLine($"{f(x):F3}");

            f = Square;
            Console.WriteLine($"{f(x):F3}");

            var calc = new Calc();
            f = calc.Cube;
            Console.WriteLine($"{f(x):F3}");
   
        }

        static double Square(double x) => x*x;
        
    }
}
