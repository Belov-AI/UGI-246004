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
    }
}
