using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    internal class Program
    {
        static Dictionary<char,char> brackets;
        static void Main(string[] args)
        {
            brackets = new Dictionary<char, char>();
            brackets[')'] = '(';
            brackets[']'] = '[';
            brackets['}'] = '{';
            brackets['>'] = '<';
            brackets['»'] = '«';

            while (true)
            {
                Console.WriteLine("Введите выражение со скобками (ENTER - выход)");

                var expression = Console.ReadLine();

                if (expression == string.Empty) return;

                if (AreBracketsCorrect(expression))
                    Console.WriteLine("Скобки расставлены верно");
                else
                    Console.WriteLine("Скобки расставлены неверно");

                Console.WriteLine();
            }
        }

        static bool AreBracketsCorrect(string expr)
        {
            var stack = new Stack<char>();

            foreach (char ch in expr) 
                if(brackets.ContainsValue(ch))
                    stack.Push(ch);
                else if(brackets.ContainsKey(ch))
                    if(stack.Count == 0 || stack.Pop() != brackets[ch])
                        return false;

            return stack.Count == 0;
        }
    }
}
