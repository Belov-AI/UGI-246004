using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Point TopLeft;
        public int Width;
        public int Height;

        public Rectangle(Point topLeft, int width, int height) 
        { 
            TopLeft = topLeft; 
            Width = width; 
            Height = height; 
        }

        public override double Area => Width * Height;

        public override object Clone() =>
            new Rectangle(TopLeft.Clone() as Point, Width, Height);

        public override void Draw()
        {
            Console.WriteLine("Рисуем прямоугольник");
        }

        public override string ToString() =>
            $"прямоугольник: верхний левй угол в точке {TopLeft} {Width}x{Height}";
    }
}
