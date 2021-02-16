using NUnit.Framework;

namespace YatzyScores.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var yatzy = new Yatzy(1, 2, 5, 2, 5);
            var points = yatzy.GetTwoPairPoints();
            Assert.AreEqual(14, points);
        }
    }
}