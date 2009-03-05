using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;

namespace TDDByExample.Tests
{
    [TestFixture]
    public class DollarTest
    {

        [Test]
        public void ShouldMultiplyFiveTimewTwoAndGet10()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10),five.times(2));
            Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.AreEqual(new Dollar(5), new Dollar(5));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));

        }
    }
}
