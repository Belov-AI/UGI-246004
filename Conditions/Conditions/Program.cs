using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 1 до 100");

            var number = int.Parse(Console.ReadLine());

            if (number > 100 || number < 1)
                Console.WriteLine("Число введено неверно");
            else
                Console.WriteLine("Число введено верно");

            Console.WriteLine("Введите номер дня недели");
            var day = int.Parse(Console.ReadLine());

            string name;

            //switch (day)
            //{
            //    case 1:
            //        name = "понедельник";
            //        break;
            //    case 2:
            //        name = "вторник";
            //        break;
            //    case 3:
            //        name = "среда";
            //        break;
            //    case 4:
            //        name = "четверг";
            //        break;
            //    case 5:
            //        name = "пятница";
            //        break;
            //    default:
            //        name = "уикенд";
            //        break;
            //}

            if (day == 1)
                name = "понедельник";
            else if (day == 2)
                name = "вторник";
            else if (day == 3)
                name = "среда";
            else if (day == 4)
                name = "четверг";
            else if (day == 5)
                name = "пятница";
            else
                name = "уикенд";

            Console.WriteLine(name);

        }
    }
}
