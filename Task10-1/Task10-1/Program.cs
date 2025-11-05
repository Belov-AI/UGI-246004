using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, отличное от 0");

            int b;

            if(!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            if(b == 0)
            { 
                Console.WriteLine("Число не должно быть равно 0");
                return;
            }

            int sum = 0;

            var lowBorder = -b * b;

            for (int a = lowBorder; a <= b; a++)
                sum += a * a * a;

            Console.WriteLine($"Сумма кубов чисел от {lowBorder} до {b} равна {sum}");
            
        }
    }
}
