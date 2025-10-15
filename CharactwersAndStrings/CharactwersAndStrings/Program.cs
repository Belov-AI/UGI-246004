using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CharactwersAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = 'z';

            letter = (char)0x42F;

            Console.WriteLine(letter);

            var smallLetter = char.ToLower(letter);
            Console.WriteLine(smallLetter);
            Console.WriteLine(letter);

            //int number = Convert.ToInt32(Console.ReadLine(), 2);
            //Console.WriteLine(number);

            Console.WriteLine("Из романа \"Евгений Онегин\"\n\nМой дядя самыx честных правил\nКогда не в шутку занемог");
            Console.WriteLine("Выравнивание влево\n123\t220\t3\n4\t59\t6");
            Console.WriteLine();
            Console.WriteLine("Выравниевание вправо\n{0,6}{1,6}{2,6}\n{3,6}{4,6}{5,6}",123,220,3,4,59,6);
            Console.WriteLine("Выравниевание вправо с плав. точкой\n{0,6:F1}{1,6:F1}{2,6:F1}\n{3,6:F1}{4,6:F1}{5,6:F1}", 
                123, 220, 3, 4, 59, 6);

            Console.WriteLine("пи = {0:F6}", Math.PI);

            Console.WriteLine();

            Console.WriteLine("C:\\Windows\\");
            var address = @"C:\Work\УрФУ\2025-2026\Программирование\Лекции\""Строки""";
            Console.WriteLine(address);
            Console.WriteLine("\x24 \b100\a");

            //string date = string.Format("{0:dd.MM.yyyy}", DateTime.Now);
            string date = $"{DateTime.Now:HH:mm dd.MM.yy}";
            Console.WriteLine(date);

            var culture = CultureInfo.CurrentCulture;
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine($"{DateTime.Now.ToLongDateString():G}");

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine($"{DateTime.Now.ToLongDateString():G}");
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
            Console.WriteLine($"{DateTime.Now.ToLongDateString():G}");

            CultureInfo.CurrentCulture = culture;
            Console.WriteLine($"{DateTime.Now.ToLongDateString():G}");
        }
    }
}
