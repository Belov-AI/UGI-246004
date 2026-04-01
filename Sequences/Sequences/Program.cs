using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace Sequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequence = new Sequence();

            PrintSecuence(sequence.Fibonacci());

            Console.WriteLine();

            PrintSecuence(sequence.Factorial());

            Console.WriteLine();
            PrintSecuence(sequence.Collatz(9));

            Console.WriteLine();
            PrintSecuence(sequence.Collatz(27));

        }

        static void PrintSecuence(IEnumerable<BigInteger> s)
        {

            foreach (var elem in s)
            {
                Thread.Sleep(200);
                Console.WriteLine(elem);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Enter)
                        break;
                }                  
            }
        }
    }
}
