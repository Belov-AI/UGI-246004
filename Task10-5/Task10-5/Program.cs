using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_5
{
    internal class Program
    {
        static double a, b, c;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a > 0");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b > 0");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c > 0");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите точность вычислений");
            var epsilon = double.Parse(Console.ReadLine());

            double result;
            double bound, step;

            if (Math.Abs(c - 1) < epsilon)
                result = c;
            else
            {
                if (c - 1 > epsilon)
                    bound = step = 1;
                else
                    bound = step = -1;

                while ((-step) * F(bound) > epsilon)
                    bound += step;

                if (step == 1)
                    result = GetRoot(0, bound, epsilon);
                else
                    result = GetRoot(bound, 0, epsilon);
            }

            Console.WriteLine($"Корень уравнения f(x) = 0 равен {result:F5}");
            
        }

        static double GetRoot(double left, double right, double epsilon)
        {
            if (left >= right)
                throw new ArgumentException("Должно быть left < right");

            double center = 0;

            while(right - left >= epsilon)
            {
                center = (left + right) / 2;

                var f = F(center);

                if (Math.Abs(f) < epsilon)
                    break;

                if (f > epsilon )
                    left = center;
                else
                    right = center;
            }

            return center;
        }

        static double F(double x) => a * x * x + b * x + c - Math.Exp(x);

    }
}
