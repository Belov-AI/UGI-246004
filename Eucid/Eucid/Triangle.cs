using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eucid
{
    public class Triangle : IRotatable
    {
        public Point A;
        public Point B;
        public Point C;
        
        public Segment AB => new Segment(A, B);
        public Segment AC => new Segment(A, C);
        public Segment BC => new Segment(B, C);

        public double Area
        {
            get
            {
                var p = (AB.Length + AC.Length + BC.Length) / 2;
                return 
                    Math.Sqrt(p * (p - AB.Length) * (p - AC.Length) * (p - BC.Length));
            }
        }
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override bool Equals(object obj)
        {
            if (obj is Triangle t)
                return A == t.A && B == t.B && C == t.C ||
                    A == t.A && B == t.C && C == t.B ||
                    A == t.B && B == t.A && C == t.C ||
                    A == t.B && B == t.C && C == t.A ||
                    A == t.C && B == t.A && C == t.B ||
                    A == t.C && B == t.B && C == t.A;

            return false;
        }

        public override string ToString() =>
            $"треугольник с вершинами в точках {A}, {B} и {C}";

        public static bool operator ==(Triangle t1, Triangle t2) =>
            t1.Equals(t2);

        public static bool operator !=(Triangle t1, Triangle t2) =>
            !t1.Equals(t2);

        public void Rotate(Point center, double AngleInDegrees)
        {
            A.Rotate(center, AngleInDegrees);
            B.Rotate(center, AngleInDegrees);
            C.Rotate(center, AngleInDegrees);
        }
    }
}
