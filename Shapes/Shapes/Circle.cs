using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public class Circle : Shape
    {
        public Point Centre;
        public int Radius;

        public Circle(Point centre, int radius, Color fillColour, Color outlineColour)
        {
            Centre = centre;
            Radius = radius;
            FillColour = fillColour;
            OutlineColour = outlineColour;
        }

        public override double Area => Math.PI * Radius * Radius;

        public override object Clone() =>
            new Circle((Point)Centre.Clone(), Radius, FillColour, OutlineColour);

        public override void Draw()
        {
            Console.WriteLine("Рисуем круг");
        }

        public override string ToString() => 
            $"круг с центром в точке {Centre} радиуса {Radius}";
    }
}
