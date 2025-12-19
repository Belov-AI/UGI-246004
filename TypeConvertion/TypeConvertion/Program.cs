using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvertion
{
    internal class Program
    {
        static int k = 5;
        static void Main(string[] args)
        {
            double x = 2;

            Console.WriteLine("x = " + x);

            x = 1.9;
            Console.WriteLine("x = " + x);

            //x = double.Parse(Console.ReadLine());
            //Console.WriteLine("x = " + x);

            int n = (int)x;
            Console.WriteLine("n = " + n);

            n = (int)Math.Round(x);
            Console.WriteLine("n = " + n);

            long m = 300000L;
            Console.WriteLine("m = " + m);

            int k;

            checked
            {
               k = (int)m;
            }

            //n = (int)m;

            Console.WriteLine("Поле k = " + Program.k);
            Console.WriteLine("Локальная переменная k = " + k);
        }
    }
}
