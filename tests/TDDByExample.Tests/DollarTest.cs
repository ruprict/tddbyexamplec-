using System.Diagnostics;
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
            Money reduced = bank.Reduce(sum, "USD");

            Assert.AreEqual(reduced, Money.dollar(10));
        }

        [Test]
        public void testPlusReturnsSum()
        {
            Money five = Money.dollar(5);
            IExpression result = five.plus(five);
            Sum sum = (Sum)result;
            Assert.AreEqual(five, sum.Augend);
            Assert.AreEqual(five, sum.Addend);
          
        }

        [Test]
        public void testReduceSum()
        {
            IExpression sum = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(7), result);
        }


        [Test]
        public void testReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.dollar(1), "USD");
            Assert.AreEqual(Money.dollar(1), result);
        }

        [Test]
        public void testReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.franc(2), "USD");
            Assert.AreEqual(Money.dollar(1), result);
        }
    }
}