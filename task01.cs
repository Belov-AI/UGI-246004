using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Александр Блок");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ночь, улица, фонарь, аптека…");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ночь, улица, фонарь, аптека,");
            Console.WriteLine("Бессмысленный и тусклый свет.");
            Console.WriteLine("Живи еще хоть четверть века —");
            Console.WriteLine("Всё будет так. Исхода нет.");

            Console.ResetColor();
        }
    }
}

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое основание трапеции");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе основание трапеции");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите угол при основании (в градусах)");
            var angleInDegrees = double.Parse(Console.ReadLine());

            var area = Math.Abs(a * a - b * b) * Math.Tan(angleInDegrees * Math.PI / 180) / 4;

            Console.WriteLine("Площадь трапеции равна " + area);
        }
    }
}