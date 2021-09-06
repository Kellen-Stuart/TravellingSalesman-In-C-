using NUnit.Framework;

namespace DataProblem1.Tests
{
    [TestFixture]
    public class PythagoreanTheoremTests
    {
        [Test]
        public void HomeToPusher()
        {
            var pointA = new Point(49.1, -123.5);
            var pointB = new Point(49.2, -123.4);
             
            Assert.AreEqual(0.14142135623730651, pointA.CalculateDistance(pointB));
        }

        [Test]
        public void SimpleTriangle()
        {
            var pointA = new Point(0, 0);
            var pointB = new Point(3, 4);
            
            Assert.AreEqual(5, pointA.CalculateDistance(pointB));
        }
    }
}