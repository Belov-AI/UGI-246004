using Eucid;

namespace Euclid.UnitTests
{
    [TestFixture]
    public class PointTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorTest()
        {
            //arrange and act
            var p = new Point(1, 2);

            //assert
            Assert.That(p.X, Is.EqualTo(1));
            Assert.That(p.Y, Is.EqualTo(2));    
        }

        [Test]
        public void ToStringTest()
        {
            //arrange
            var p = new Point(1.5, -3.1);

            //act
            var info = p.ToString();

            //assert
            Assert.That(info, Is.EqualTo("(1,5; -3,1)"));
        }
        
        [TestCase(1, -2, true)]
        [TestCase(1, -3, false)]
        [TestCase(0, -2, false)]
        public void Equals_Points_Test(double x, double y, bool result)
        {
            var p = new Point(1, -2);
            var q = new Point(x, y);

            Assert.That(p,Is.Not.SameAs(q));
            Assert.That(p.Equals(q), Is.EqualTo(result));
        }

        [Test]
        public void Equals_Object_False()
        {
            var p = new Point(1, -2);
            var q = new object();

            Assert.That(p.Equals(q), Is.False);
        }

        [Test]
        public void RotateTest()
        {
            var p = new Point(3, 1);
            var c = new Point(1, 2);
            //var q = new Point(38.253460551035401997169716348762, 
            //    2.1342157191853424413293579680965);

            p.Rotate(c, 30);

            //Assert.That(p == q, Is.True);

        }
    }
}
