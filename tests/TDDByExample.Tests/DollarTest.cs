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
            five.times(2);
            Assert.AreEqual(five.Amount,10);
        }
    }
}
