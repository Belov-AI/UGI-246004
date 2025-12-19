using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону треугольника");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону треугольника");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третью сторону треугольника");
            var c = double.Parse(Console.ReadLine());

            var p = (a + b + c) / 2.0;
            var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 

            var r = area / p;              
            var R = (a * b * c) / (4 * area);

            Console.WriteLine("Площадь треугольника равна " + area);
            Console.WriteLine("Радиус вписанной окружности равен " + r);
            Console.WriteLine("Радиус описанной окружности равен " + R);
        }
    }
}
