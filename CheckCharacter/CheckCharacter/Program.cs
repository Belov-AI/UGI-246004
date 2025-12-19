using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");

            var input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("Символа нет :(");
                return;
            }
            else if (input.Length > 1) 
            {
                Console.WriteLine("Слишком много символов");
                return;
            }

            var ch = input[0];

            if (char.IsUpper(ch))
                Console.WriteLine($"{ch} — заглавная буква");
            else if (char.IsLower(ch))
                Console.WriteLine($"{ch} — строчная буква");
            else if (char.IsWhiteSpace(ch))
                Console.WriteLine("Это пробел");
            else if (char.IsDigit(ch))
                Console.WriteLine($"{ch} — цифра");
            else if (char.IsPunctuation(ch))
                Console.WriteLine($"{ch} — знак пунктуации");
            else
                Console.WriteLine($"{ch} — специальный символ");

        }
    }
}
