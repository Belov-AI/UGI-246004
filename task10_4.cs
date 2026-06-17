using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var n = long.Parse(Console.ReadLine());

            var lastDigit = (int)(n % 10);
            int count = 0;

            var numb = n;
            while (numb > 0)
            {
                var digit = (int)(numb % 10);
                if (digit == lastDigit)
                    count++;

                numb /= 10;
            }

            Console.WriteLine($"Последняя цифра {lastDigit} встречается {count} раз(а)");
        }
    }
}
