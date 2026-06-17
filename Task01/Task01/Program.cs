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
            Console.WriteLine("Кобаяси Иса");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Хокку");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Тихи, тихо ползи,");
            Console.WriteLine("Улитка, по склону Фудзи.");
            Console.WriteLine("Вверх, до самых высот.");

            Console.ResetColor();
        }
    }
}
