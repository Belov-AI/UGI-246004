using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесиво чисел");
            var n = int.Parse(Console.ReadLine());

            var queues = new Queue<int>[10];

            for(int i = 0; i < queues.Length; i++)
                queues[i] = new Queue<int>();

            var rnd = new Random();

            for(int counter = 0; counter < n; counter++)
            {
                var number = rnd.Next(1,1000);
                var lastDigit = number % 10;
                queues[lastDigit].Enqueue(number);

                Console.Write($"{number} ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < queues.Length; i++)
            {
                Console.WriteLine($"Числа, заканчивающиеся на {i}:");

                while (queues[i].Count > 0)
                    Console.Write($"{queues[i].Dequeue()} ");

                Console.WriteLine("\n");
            }

        }
    }
}
