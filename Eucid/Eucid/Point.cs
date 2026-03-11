using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucid
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y) 
        { 
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}; {Y})";
        public override bool Equals(object obj)
        {
            if (obj is Point p)
                return Math.Abs(X - p.X) < 1e-13 && Math.Abs(Y - p.Y) < 1e-13;

            return false;
        }

        public static bool operator ==(Point p, Point q) => p.Equals(q);

        public static bool operator !=(Point p, Point q) => !p.Equals(q);
    }
}
