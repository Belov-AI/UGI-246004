using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6.1
            Console.WriteLine("Введите текст на английском языке:");
            var text = Console.ReadLine();

            var leet = ToLeet(text);
            Console.WriteLine("Leet: " + leet);

            // 6.2
            var source = "метаморфоза";
            var moroz = GetMoroz(source);
            var metro = GetMetro(source);

            Console.WriteLine("Исходное слово: " + source);
            Console.WriteLine("Слово \"мороз\": " + moroz);
            Console.WriteLine("Слово \"метро\": " + metro);
        }

        static string ToLeet(string input)
        {
            var result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result += ConvertCharToLeet(input[i]);
            }

            return result;
        }

        static string ConvertCharToLeet(char ch)
        {
            // Приводим к верхнему регистру, чтобы одна таблица замен работала для a/A и т.п.
            var c = char.ToUpper(ch);

            switch (c)
            {
                case 'A': return "4";
                case 'B': return "8";
                case 'C': return "(";
                case 'D': return "|)";
                case 'E': return "3";
                case 'F': return "|=";
                case 'G': return "6";
                case 'H': return "|-|";
                case 'I': return "!";
                case 'J': return ")";
                case 'K': return "|<";
                case 'L': return "1";
                case 'M': return "|\\/|";
                case 'N': return "|\\|";
                case 'O': return "0";
                case 'P': return "|>";
                case 'Q': return "9";
                case 'R': return "|2";
                case 'S': return "5";
                case 'T': return "7";
                case 'U': return "|_|";
                case 'V': return "\\/";
                case 'W': return "\\/\\/";
                case 'X': return "><";
                case 'Y': return "`/";
                case 'Z': return "2";
                default: return ch.ToString();
            }
        }

        static string GetMoroz(string s)
        {
            // "мороз" = "мо" + "роз"
            // "мо" берём из "метаморфоза" (индексы 0..1), "роз" — из "морфоза" (индексы 5..7)
            return s.Substring(5, 2) + s.Substring(7, 3);
        }

        static string GetMetro(string s)
        {
            // "метро" = "мет" + "ро"
            // "мет" — первые 3 буквы, "ро" — из "морфоза" (индексы 7..8)
            return s.Substring(0, 3) + s.Substring(7, 2);
        }
    }
}