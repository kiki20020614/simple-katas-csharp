using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeapYear
{
    public class LeapTest
    {
        [Test]
        public void Year_not_divisible_by_4_is_common_year()
        {
            Assert.False(Leap.IsLeapYear(2015));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Year_divisible_by_4_not_divisible_by_100_is_leap_year()
        {
            Assert.True(Leap.IsLeapYear(2016));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Year_divisible_by_100_not_divisible_by_400_is_common_year()
        {
            Assert.False(Leap.IsLeapYear(2100));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Year_divisible_by_400_is_leap_year()
        {
            Assert.True(Leap.IsLeapYear(2000));
        }
    }
}
