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
            var k =int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число m");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (IfLogicalExpressionTrue(k, m, n))
                Console.WriteLine("k, m, n - четные, причем k <= n <= n");
            else
                Console.WriteLine("Либо одно из введенных чисел нечетное, " +
                    "либо первое больше второго или второе больше третьего");
        }

        static bool IfLogicalExpressionTrue(int k, int m, int n) =>
            (k % 2 == 0) && (m % 2 == 0) && (n % 2 == 0) && (k <= m) && (m <=n);
    }
}
