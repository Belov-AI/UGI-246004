using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSequence
{
    class Program
    {
        static void Main()
        {
            const int N = 100_000_000;

            int[] a = new int[N + 1];
            a[1] = 1;

            long sum = 1;

            for (int k = 2; k <= N; k++)
            {
                a[k] = GetA(k, a);
                sum += a[k];
            }

            Console.WriteLine(sum);
        }

        static int GetA(int k, int[] a)
        {
            if (k % 2 == 0)
            {
                return k; 
            }
            else
            {
                int n = k / 2;
                return a[n] - 3 * a[n + 1];
            }
        }
    }
}
