using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите натуральное число k");
            var k = int.Parse(Console.ReadLine());

            double sum = 0;
            double term = 1; // 1 / n^0

            for (int i = 0; i <= k; i++)
            {
                // знак: + для четных i, - для нечетных i
                sum += (i % 2 == 0) ? term : -term;
                term /= n; // переходим к 1 / n^(i+1)
            }

            Console.WriteLine($"Сумма = {sum}");
        }
    }
}