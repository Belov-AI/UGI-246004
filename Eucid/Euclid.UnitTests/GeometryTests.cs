using Eucid;
using Euclid;

namespace Euclid.UnitTests
{
    [TestFixture]
    public class GeometryTests
    {
        [TestCase(2, 2, false)]
        [TestCase(2, 1.5, true)]
        [TestCase(1, 1, true)]
        [TestCase(3, 2, true)]
        [TestCase(5, 3, false)]
        [TestCase(-1, 0, false)]
        public void IsSegmentContainsPointTest(double pX, double pY, bool result)
        {
            var s = new Segment(new Point(1, 1), new Point(3, 2));
            var p = new Point(pX, pY);

            Assert.That(Geometry.IsSegmentContainsPoint(s, p), 
                Is.EqualTo(result));
        }

        [Test]
        public void CreateSegment_DifferentPoints_Creation()
        {
            var a = new Point(1, 1);
            var b = new Point(3, 2);

            var s = Geometry.CreateSegment(a, b);

            Assert.That(s.A, Is.EqualTo(a));
            Assert.That(s.B, Is.EqualTo(b));
        }

        [Test]
        public void CreateSegment_EqualPoints_ArgumentException()
        {
            var a = new Point(1, 1);
            var b = new Point(1, 1);

            //Assert.That(() => Geometry.CreateSegment(a, b),
            //    Throws.ArgumentException);

            var ex = Assert.Throws<ArgumentException>(
                () => Geometry.CreateSegment(a, b));

            Assert.That(ex.Message, Is.EqualTo(
                "Попытка создания отрезка с совпадающими концами (1; 1)"));
        }

        [Test]
        public void CreateProperTriangle()
        {
            var a = new Point(1, 1);
            var b = new Point(3, 1);
            var c = new Point(3, 2);

            var t = Geometry.CreateTriangle(a, b, c);

            Assert.That(t.A, Is.EqualTo(a));
            Assert.That(t.B, Is.EqualTo(b));
            Assert.That(t.C, Is.EqualTo(c));
        }

        [Test]
        public void CreateDegeneratedTriangle()
        {
            var a = new Point(1, 1);
            var b = new Point(-1, 0);
            var c = new Point(3, 2);

            var ex = Assert.Throws<ArgumentException>(
                () => Geometry.CreateTriangle(a, b, c));

            Assert.That(ex.Message, Is.EqualTo(
                "Попытка создания вырожденного треугольника"));
        }

    }
}
