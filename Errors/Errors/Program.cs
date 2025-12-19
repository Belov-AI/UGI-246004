using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель");

            //var x = int.Parse(Console.ReadLine());

            int numerator;

            if (!int.TryParse(Console.ReadLine(), out numerator))
                Console.WriteLine("Введенная строка не соотвествует целому числу");

            Console.WriteLine("Введите знаменатель");
            int denominator;
            if (!int.TryParse(Console.ReadLine(), out denominator))
                Console.WriteLine("Введенная строка не соотвествует целому числу");

            double quotient = 1;

            //quotient = numerator / denominator;

            try
            {
                quotient = numerator / denominator;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                while (true)
                {
                    Console.WriteLine("Введите знаменатель повторно");

                    if (!int.TryParse(Console.ReadLine(), out denominator) || denominator == 0)
                    {
                        Console.WriteLine("Ошибка ввода");
                        continue;
                    }
                    else
                    {
                        quotient = numerator / denominator;
                        break;
                    }
                }
            }

            Console.WriteLine($"Частное от деления равно {quotient}");
        }
    }
}
