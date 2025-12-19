using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = InputNumber("Введите 1-ю координату");
            var y = InputNumber("Введите 2-ю координату");

            Console.WriteLine("Точка (" + x + ", " + y + ")");
            Console.WriteLine("Длина радиус-вектора " + Math.Sqrt(GetSquare(x) + GetSquare(y)));

            var z = InputNumber("Введите любое число", " с плавающей точкой");
            Console.WriteLine("Его квадрат равен " + GetSquare(z));

            var k = InputNumber("Введите 1-e число");
            var m = InputNumber("Введите 2-e число");
            var n = InputNumber("Введите 3-e число");
            Console.WriteLine("Самое большое из них равно " + GetMax(k,m,n));

        }

        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        static double InputNumber(string message1, string message2)
        {
            Console.WriteLine(message1 + message2);
            return double.Parse(Console.ReadLine());
        }

        static int GetSquare(int x) => x * x;
        static double GetSquare(double x) => x * x;

        /// <summary>
        /// находит наибольшее значение аргументов
        /// </summary>
        /// <param name="x">1-е число</param>
        /// <param name="y">2-е число</param>
        /// <param name="z">3-е число</param>
        /// <returns></returns>
        static double GetMax(double x, double y, double z) => Math.Max(Math.Max(x,y),z);
        static double GetMax(double x, double y, double z, double w) => 
            Math.Max(GetMax(x,y,z),w);
    }
}
