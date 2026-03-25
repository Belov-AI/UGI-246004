using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Eucid
{
    public static class Geometry
    {
        public static Segment CreateSegment(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
                throw new ArgumentException(
                    $"Попытка создания отрезка с совпадающими концами {a.ToString()}");

            return new Segment(a, b);
        }

        public static bool IsSegmentContainsPoint(Segment s, Point p) => s.IsContains(p);

        public static Triangle CreateTriangle(Point a, Point b, Point c)
        {
            var t = new Triangle(a,b,c);

            if (t.AB.Length + t.AC.Length - t.BC.Length >= 1e-13 &&
                t.AC.Length + t.AB.Length - t.BC.Length >= 1e-13 &&
                t.BC.Length + t.AC.Length - t.AB.Length >= 1e-13)
                return t;

            throw new ArgumentException(
                "Попытка создания вырожденного треугольника");

        }
    }
}
