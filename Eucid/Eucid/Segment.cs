using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Eucid
{
    public class Segment : IRotatable
    {
        public Point A;
        public Point B;

        public double Length
        {
            get
            {
                var dx = A.X - B.X;
                var dy = A.Y - B.Y;

                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public Segment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public override string ToString() => $"отрезок с концами в точках {A.ToString()} и {B.ToString()}";

        public bool IsContains(Point p) 
        { 
            var apX = p.X - A.X;
            var apY = p.Y - A.Y;
            var pbX = B.X - p.X;
            var pbY = B.Y - p.Y;

            return Math.Abs(apX * pbY - apY * pbX) < 1e-13 &&
                apX * pbX + apY * pbY > -1e-13;
        }

        public override bool Equals(object obj)
        {
            if (obj is Segment s)
                return A == s.A && B == s.B || A == s.B && B == s.A;
            
            return false;
        }

        public void Rotate(Point center, double AngleInDegrees)
        {
            A.Rotate(center, AngleInDegrees);
            B.Rotate(center, AngleInDegrees);
        }

        public static bool operator ==(Segment s1, Segment s2) =>
            s1.Equals(s2);

        public static bool operator !=(Segment s1, Segment s2) =>
            !s1.Equals(s2);
    }
}
