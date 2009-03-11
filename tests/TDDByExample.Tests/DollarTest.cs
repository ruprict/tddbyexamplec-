using MbUnit.Framework;

namespace TDDByExample.Tests
{
    [TestFixture]
    public class DollarTest
   { 
        [Test]
        public void ShouldMultiplyFiveTimewTwoAndGet10()
        {
            Money five = Money.dollar(5);
            Assert.AreEqual(Money.dollar(10), five.times(2));
            Assert.AreEqual(Money.dollar(15), five.times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));
        }

        [Test]
        public void testFrancMultiplication()
        {
            var five = Money.franc(5);
            Assert.AreEqual(Money.franc(10), five.times(2));
            Assert.AreEqual(Money.franc(15), five.times(3));
        }

        [Test]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.dollar(1).Currency);
            Assert.AreEqual("CHF", Money.franc(1).Currency);
        }

        [Test]
        public void testSimpleAddition()
        {
            Money five = Money.dollar(5);
            IExpression sum = five.plus(five);
            Bank bank = new Bank();
            Money reduced = bank.reduce(sum, "USD");

            Assert.AreEqual(reduced,Money.dollar(10));
        }
    }
}