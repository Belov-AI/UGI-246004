using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число");

            var x = double.Parse(Console.ReadLine());
            var y = F(x);

            Console.WriteLine("y = " + y);

            //y = Foo(y);
        }

        static double F(double x) => Math.Sqrt((1 + Math.Cos(x))/(1 + x * x));

        static double Foo(double x)
        { 
            throw new NotImplementedException();
        }
    }
}
