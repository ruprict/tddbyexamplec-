using MbUnit.Framework;

namespace TDDByExample.Tests
{
    [TestFixture]
    public class DollarTest
    {
        [Test]
        public void ShouldMultiplyFiveTimewTwoAndGet10()
        {
            var five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.times(2));
            Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        }

        [Test]
        public void testFrancMultiplication()
        {
            var five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.times(2));
            Assert.AreEqual(new Franc(15), five.times(3));
        }
    }
}