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
            Console.WriteLine("Введите пятизначное число");

            var n = int.Parse(Console.ReadLine());

            // Выделяем цифры пятизначного числа abcde
            var a = n / 10000;       
            var c = (n / 100) % 10;  
            var e = n % 10;      

            // Получаем трехзначное число ace (вычеркнули 2-ю и 4-ю цифры)
            var result = a * 100 + c * 10 + e;

            Console.WriteLine("Вот что получилось: " + result);
        }
    }
}
