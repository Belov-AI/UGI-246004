using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");

            var n = int.Parse(Console.ReadLine());

            var tenths = n / 10;
            var units = n % 10;

            var result = tenths * 1001 + units * 110;

            Console.WriteLine("Вот что получилось: " + result);
        }
    }
}
