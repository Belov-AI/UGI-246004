using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eucid;

namespace Euclid.UnitTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ConstructorTest()
        {
            var a = new Point (1, 2);
            var b = new Point (3, 4);
            var c = new Point (-1, 5);

            var t = new Triangle (a, b, c);

            Assert.That(t.A, Is.SameAs(a));
            Assert.That(t.B, Is.SameAs(b));
            Assert.That(t.C, Is.SameAs(c));
        }

        [Test]
        public void SidesTest()
        {
            var t = GetTestTriangle();
            var sideAB = new Segment(new Point(1,1), new Point(3,1));
            var sideAC = new Segment(new Point(1, 1), new Point(3, 2));
            var sideBC = new Segment(new Point(3, 2), new Point(3, 1));

            Assert.That(t.AB == sideAB, Is.True);
            Assert.That(t.AC == sideAC, Is.True); 
            Assert.That(t.BC == sideBC, Is.True);
        }

        [Test]
        public void AreaTest()
        {
            var t = GetTestTriangle();
            Assert.That(t.Area, Is.EqualTo(1).Within(1e-13));

        }

        [Test]
        public void ToStringTest()
        {
            var t = GetTestTriangle();
            Assert.That(t.ToString(), Is.EqualTo(
                "треугольник с вершинами в точках (1; 1), (3; 1) и (3; 2)"));
        }

        Triangle GetTestTriangle() =>
            new Triangle(new Point(1, 1), new Point(3, 1), new Point(3, 2));       
    }
}
