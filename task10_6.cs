using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            for (int y = x; y <= 100; y++)
            for (int z = y; z <= 100; z++)
            for (int w = z; w <= 100; w++)
            {
                int left = x * x + y * y + z * z;
                int right = w * w;

                if (left == right)
                    Console.WriteLine($"{x} {y} {z} {w}");
            }
        }
    }
}
