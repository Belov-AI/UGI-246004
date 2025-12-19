using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа m и n от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out m) &&
                    int.TryParse(parts[1], out n) &&
                    5 <= m && m <= 20 &&
                    5 <= n && n <= 20)
                    break;

                Console.WriteLine("Ошибка ввода");
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)         
                for (int j = 0; j < matrix.GetLength(1); j++)      
                    matrix[i, j] = rnd.Next(0, 100);

            Console.WriteLine();
            PrintTable(matrix);
            Console.WriteLine();

            // а)
            if (AreRowsIncreasing(matrix, out int rowIndex, out int colIndex))
                Console.WriteLine("Строки массива упорядочены по возрастанию");
            else
                Console.WriteLine($"Нарушение порядка: строка {rowIndex}, столбцы {colIndex} и {colIndex + 1}");

            Console.WriteLine();

            // б)
            var sums = GetOddSumsByColumns(matrix);
            for (int j = 0; j < sums.Length; j++)
                Console.WriteLine($"Столбец {j}: сумма нечетных = {sums[j]}");
        }

        static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],3} ");

                Console.WriteLine();
            }
        }

        // а) true, если все строки строго возрастают
        static bool AreRowsIncreasing(int[,] table, out int badRow, out int badCol)
        {
            for (int i = 0; i < table.GetLength(0); i++)
                for (int j = 0; j < table.GetLength(1) - 1; j++)
                    if (table[i, j] >= table[i, j + 1])
                    {
                        badRow = i;
                        badCol = j;
                        return false;
                    }

            badRow = -1;
            badCol = -1;
            return true;
        }

        // б) суммы нечетных элементов по каждому столбцу
        static int[] GetOddSumsByColumns(int[,] table)
        {
            var cols = table.GetLength(1);
            var rows = table.GetLength(0);
            var result = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int sum = 0;

                for (int i = 0; i < rows; i++)
                    if (table[i, j] % 2 != 0)
                        sum += table[i, j];

                result[j] = sum;
            }

            return result;
        }
    }
}
