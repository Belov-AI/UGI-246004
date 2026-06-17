using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите целые числа (последовательность оканчивается 0)");

            int changes = 0;

            var first = int.Parse(Console.ReadLine());
            if (first == 0)
            {
                Console.WriteLine("0");
                return;
            }

            var prev = first;

            while (true)
            {
                var current = int.Parse(Console.ReadLine());
                if (current == 0)
                    break;

                if ((prev > 0 && current < 0) || (prev < 0 && current > 0))
                    changes++;

                prev = current;
            }

            Console.WriteLine($"Количество смен знака = {changes}");
        }
    }
}
