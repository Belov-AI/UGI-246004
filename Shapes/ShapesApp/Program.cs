using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
using System.Drawing;
using System.CodeDom;

namespace ShapesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = new Shapes.Point(2, 5, Color.Blue);
            Console.WriteLine(point);

            var cirle = new Circle(point, 3, Color.LightGreen, Color.Green);
            //Console.WriteLine(cirle);

            var retangle = 
                new Shapes.Rectangle(new Shapes.Point(1, 1, Color.BlueViolet), 20, 30);
            //Console.WriteLine(retangle);

            var shapes = new Shape[] {cirle, retangle};

            foreach(var shape in shapes)
                Console.WriteLine(shape + $" площади {shape.Area:F3}");

            foreach (var shape in shapes)
                shape.Draw();
        }
    }
}
