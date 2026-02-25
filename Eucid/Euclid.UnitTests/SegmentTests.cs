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
    }
}
