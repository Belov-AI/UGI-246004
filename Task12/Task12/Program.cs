using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа n и m от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                var strings = input.Split();

                if (strings.Length == 2 && int.TryParse(strings[0], out m) && 
                    int.TryParse(strings[1], out n) && 5 <= m && m <= 20 &&
                    5 <= n && n <= 20)
                    break;
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
            }

            var matrix = new int[m, n];

            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

            PrintTable(matrix);

            var index = GetMinLastElemColumnIndex(matrix);

            if (index >= 0)
                Console.WriteLine($"У столбца с индексом {index} последний элемент наименьший");
            else
                Console.WriteLine("Нет столбца с последним наименьшим элементом");
        }

        static void PrintTable(int[,] table)
        {
            for (int i = 0;i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],2} ");

                Console.WriteLine();
            }               
        }

        static int GetMinLastElemColumnIndex(int[,] table)
        {
            var lastRowIndex = table.GetLength(0) - 1;

            for (int j = 0; j < table.GetLength(1); j++)
            {
                var isWrong = false;

                for (int i = 0; i < lastRowIndex; i++)
                    if (table[i, j] < table[lastRowIndex, j])
                    {
                        isWrong = true;
                        break;
                    }

                if (isWrong)
                    continue;
                else
                    return j;
            }

            return -1;              
        }
    }
}
