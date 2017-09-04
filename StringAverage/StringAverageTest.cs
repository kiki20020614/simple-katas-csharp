using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringAverage
{
    [TestFixture]
    public class StringAverageTest
    {
        [Test]
        public void String_Is_Empty_Return_NA()
        {
            Assert.AreEqual("n/a", StrAvg.StringAvg(string.Empty));
        }

        [Test]
        public void String_Is_one_Return_one()
        {
            Assert.AreEqual("one", StrAvg.StringAvg("one"));
        }
    }
}
