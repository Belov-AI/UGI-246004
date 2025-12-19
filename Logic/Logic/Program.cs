using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ещё одно число");
            double y = double.Parse(Console.ReadLine());

            bool z = x > y;
            bool w = x + y >= x * y;

            Console.WriteLine($"z = {z}, w = {w}");

            bool left = !(z && w);
            bool right = !z || !w;

            Console.WriteLine(left == right);

            Console.WriteLine("Введите целое число");
            var  k = int.Parse(Console.ReadLine());
            Console.WriteLine($"k = {Convert.ToString(k, 2)}");
            Console.WriteLine("Введите ещё одно целое число");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"n = {Convert.ToString(n, 2)}");

            Console.WriteLine($"k & n = {k & n}");
            Console.WriteLine($"k & n = {Convert.ToString(k & n, 2)}");

        }
    }
}
