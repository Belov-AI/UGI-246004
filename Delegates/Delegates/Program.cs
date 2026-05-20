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

            f = s => Math.Sqrt( s );
            Console.WriteLine($"{f(x):F3}");

            var array1 = new[] { 1, 2, 3, 4, 5 };
            PrintIntArray(array1);

            var array2 = new[] { 6, 7, 8, 9 };
            PrintIntArray(array2);

            PrintIntArray(Zip(array1, array2, calc.Product));
            PrintIntArray(Zip(array1,array2, (a,b) => a + b));

            PrintIntArray(Zip(array1, array2, calc.Normalize));

        }

        static double Square(double x) => x*x;

        static int[] Zip(int[] x, int[] y, Func<int,int,int> f)
        {
            var length = Math.Min(x.Length, y.Length);
            var result = new int[length];

            for(int i = 0; i < length; i++)
            {
                result[i] = f(x[i],y[i]);
            }

            return result;
        }
        
        static void PrintIntArray(int[] array)
        {
            foreach(var number in array)
                Console.Write($"{number} ");

            Console.WriteLine("\n");
        }
    }
}
