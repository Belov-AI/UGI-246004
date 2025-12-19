using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое натуральное число");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе натуральное число");
            var b = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Оба числа должны быть натуральными");
                return;
            }

            var min = a < b ? a : b;
            var gcd = 1;

            for (int d = 1; d <= min; d++)
            {
                if (a % d == 0 && b % d == 0)
                    gcd = d;
            }

            Console.WriteLine($"НОД = {gcd}");
        }
    }
}
