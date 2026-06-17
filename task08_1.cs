using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число k");
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число m");
            var m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (IfLogicalExpressionTrue(k, m, n))
                Console.WriteLine("Хотя бы одно из чисел k, m, n не делится на 7, и их сумма четная");
            else
                Console.WriteLine("Либо все числа делятся на 7, либо сумма нечетная");
        }

        static bool IfLogicalExpressionTrue(int k, int m, int n) =>
            ((k % 7 != 0) || (m % 7 != 0) || (n % 7 != 0)) && ((k + m + n) % 2 == 0);
    }
}