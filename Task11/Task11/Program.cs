using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MODULE = 101;

            Console.WriteLine("Введите число элементов массива");

            var n = int.Parse(Console.ReadLine());

            if( n < 1)
            {
                Console.WriteLine("Слишком маленький массив.");
                return;
            }

            var numbers = new int[n];

            numbers[0] = 1;

            if(n > 1)
            {
                numbers[1] = 1;

                for(int i = 2; i < numbers.Length; i++)
                    numbers[i] = (numbers[i-1] + numbers[i-2]) % MODULE;
            }

            PrintIntArray(numbers);

            ChangeSignOfOdds(numbers);
            PrintIntArray(numbers);

            var harmonicalAverage = GetHarmonicalAverage(numbers);
            Console.WriteLine($"Среднее гармоническое элементов {harmonicalAverage:F6}\n");

            PrintIntArray(ShiftByMinElement(numbers));
        }

        static void PrintIntArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item}, ");

            Console.WriteLine("\b\b.\n");
        }

        static void ChangeSignOfOdds(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0)
                    array[i] *= -1;
        }

        static double GetHarmonicalAverage(int[] array)
        {
            double sum = 0;
            int counter = 0;

            foreach (var item in array)
                if(item != 0)
                {
                    sum += 1.0 / Math.Abs(item);
                    counter++;
                }

            if (counter > 0)
                return sum / counter;

            return 0;
        }

        static int[] ShiftByMinElement(int[] array)
        {
            var minimum = int.MaxValue;

            foreach(var item in array)
                if(item < minimum)
                    minimum = item;

            var result = new int[array.Length];

            for(int i = 0;i < result.Length; i++)
                result[i] = array[i] - minimum;

            return result;
        }
    }
}
