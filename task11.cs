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
            Console.WriteLine("Введите число элементов массива");
            var n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Слишком маленький массив.");
                return;
            }

            var array = CreateRandomArray(n);

            PrintDoubleArray(array);

            ChangeArrayByFormula(array); 
            PrintDoubleArray(array);

            var rms = GetRootMeanSquare(array);
            Console.WriteLine($"Среднее квадратичное = {rms:F3}\n");

            var shifted = SubtractAverage(array); 
            PrintDoubleArray(shifted);
        }

        static double[] CreateRandomArray(int n)
        {
            var rnd = new Random();
            var result = new double[n];

            for (int i = 0; i < result.Length; i++)
            {
                var integerPart = rnd.Next(0, 100);   
                var fractionalPart = rnd.NextDouble(); 
                result[i] = integerPart * fractionalPart;
            }

            return result;
        }

        static void PrintDoubleArray(double[] array)
        {
            foreach (var item in array)
                Console.Write($"{item:F3}; ");

            Console.WriteLine("\b\b\n");
        }

        static void ChangeArrayByFormula(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var a = array[i];
                array[i] = 1.0 + 1.0 / Math.Sqrt(1.0 + a); 
            }
        }

        static double GetRootMeanSquare(double[] array)
        {
            double sumSquares = 0;

            foreach (var x in array)
                sumSquares += x * x;

            return Math.Sqrt(sumSquares / array.Length);
        }

        static double[] SubtractAverage(double[] array)
        {
            double sum = 0;
            foreach (var x in array)
                sum += x;

            var avg = sum / array.Length;

            var result = new double[array.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = array[i] - avg;

            return result;
        }
    }
}