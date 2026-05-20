using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Calc
    {
        public double Cube(double x) => x * x * x;

        public int Product(int x, int y) => x * y;

        public int Normalize(int x, int y) => x * x + y * y;
    }
}
