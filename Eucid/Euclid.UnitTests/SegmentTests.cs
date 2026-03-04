using Eucid;

namespace Euclid.UnitTests
{
    [TestFixture]
    public class SegmentTests
    {
        [Test]
        public void ConstructorTest()
        {
            var a = new Point(1.5, 2.3);
            var b = new Point(-1.7, 4.8);

            var s = new Segment(a, b);

            Assert.That(s.A, Is.SameAs(a));
            Assert.That(s.B, Is.SameAs(b));
        }

        [Test]
        public void GetInfoTest()
        {
            var s = GetTestSegment(1.5, -2.1, 4, 0.8);

            Assert.That(s.GetInfo(), Is.EqualTo(
                "отрезок с концами в точках (1,5; -2,1) и (4; 0,8)"));
        }

        [Test]
        public void LengthTest()
        {
            var s = GetTestSegment(1, 1, 3, 2);

            Assert.That(s.Length, Is.EqualTo(2.2360679774997).Within(1e-13));
        }

        [TestCase(2, 2, false)]
        [TestCase(2, 1.5, true)]
        [TestCase(1, 1, true)]
        [TestCase(3, 2, true)]
        [TestCase(5, 3, false)]
        [TestCase(-1, 0, false)]
        public void IsContainsTest(double pX, double pY, bool result)
        {
            var s = GetTestSegment(1, 1, 3, 2);
            var p = new Point(pX, pY);

            Assert.That(s.IsContains(p), Is.EqualTo(result));
        }

        private Segment GetTestSegment(
            double aX, double aY, double bX, double bY) =>
            new Segment(new Point(aX, aY), new Point(bX, bY));
    }
}
