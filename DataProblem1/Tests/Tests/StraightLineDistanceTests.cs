using NUnit.Framework;

namespace DataProblem1.Tests
{
    [TestFixture]
    public class StraightLineDistanceTests
    {
        [Test]
        public void StraightUp()
        {
            var pointA = new Point(0, 0);
            var pointB = new Point(0, 5);
            
            Assert.AreEqual(5, pointA.CalculateDistance(pointB));
        }

        [Test]
        public void StraightAcross()
        {
            var pointA = new Point(0, 0);
            var pointB = new Point(5, 0);
            
            Assert.AreEqual(5, pointA.CalculateDistance(pointB));
        }
    }
}