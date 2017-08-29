using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TwoFer
{
    public class TwoferTest
    {
        private Twofer twofer;

        [SetUp]
        public void SetUp()
        {
            twofer = new Twofer();
        }

        [Test]
        public void NoNameGiven()
        {
            String input = null;
            String expected = "One for you, one for me.";

            Assert.AreEqual(expected, twofer.Say(input));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void ANameGiven()
        {
            String input = "Alice";
            String expected = "One for Alice, one for me.";

            Assert.AreEqual(expected, twofer.Say(input));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void AnotherNameGiven()
        {
            String input = "Bob";
            String expected = "One for Bob, one for me.";

            Assert.AreEqual(expected, twofer.Say(input));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void EmptyStringGiven()
        {
            String input = "";
            String expected = "One for , one for me.";

            Assert.AreEqual(expected, twofer.Say(input));
        }

    }
}
