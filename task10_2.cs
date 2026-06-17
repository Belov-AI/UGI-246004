using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел n (n >= 2)");
            var n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("n должно быть >= 2");
                return;
            }

            double sum = 0;
            double sumSquares = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите x{i + 1}");
                var x = double.Parse(Console.ReadLine());

                sum += x;
                sumSquares += x * x;
            }

            var mean = sum / n;
            var D = (sumSquares / n) - mean * mean;        // выборочная дисперсия D [web:139]
            var S = (n / (double)(n - 1)) * D;             // исправленная дисперсия S [web:139]

            Console.WriteLine($"S = {S}");
        }
    }
}
