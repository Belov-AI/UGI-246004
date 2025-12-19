using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            var rnd = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100);
            }

            PrintArray(a);

            Array.Sort(a);
            PrintArray(a);

            SortIntArrayByDecreasing(a);
            PrintArray(a);
        }

        static void PrintArray(int[] a)
        {
            foreach (int elem in a)
                Console.Write($"{elem} ");

            Console.WriteLine();
        }

        static void SortIntArrayByDecreasing(int[] a)
        {
            ChangeSign(a);
            Array.Sort(a);
            ChangeSign(a);
        }

        static void ChangeSign(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= -1;
        }
    }
}
