using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RnaTranscription
{
    public class RnaTranscriptionTest
    {
        [Test]
        public void RnaTranscriptionOfEmptyDnaIsEmptyRna()
        {
            Assert.AreEqual("", Rna.Transcribe(""));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void RnaTranscriptionOfCytosineIsGuanine()
        {
            Assert.AreEqual("G", Rna.Transcribe("C"));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void RnaTranscriptionOfGuanineIsCytosine()
        {
            Assert.AreEqual("C", Rna.Transcribe("G"));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void RnaTranscriptionOfThymineIsAdenine()
        {
            Assert.AreEqual("A", Rna.Transcribe("T"));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void RnaTranscriptionOfAdenineIsUracil()
        {
            Assert.AreEqual("U", Rna.Transcribe("A"));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void RnaTranscription()
        {
            Assert.AreEqual("UGCACCAGAAUU", Rna.Transcribe("ACGTGGTCTTAA"));
        }

        [Ignore("Remove to run test")]
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Invalid input")]
        public void RnaTranscriptionOfRnaThrowsAnError()
        {
            Rna.Transcribe("U");
        }

        [Ignore("Remove to run test")]
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Invalid input")]
        public void RnaTranscriptionOfInvalidInputThrowsAnError()
        {
            Rna.Transcribe("BFV");
        }

        [Ignore("Remove to run test")]
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Invalid input")]
        public void RnaTranscriptionOfPartiallyInvalidInput()
        {
            Rna.Transcribe("GCVV");
        }

    }
}
