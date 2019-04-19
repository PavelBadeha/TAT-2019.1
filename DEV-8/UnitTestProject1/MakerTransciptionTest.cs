using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_8.Test
{
    [TestClass]
    public class MakerTransciptionTest
    {
        MakerTranscription test = new MakerTranscription("молоко+");
        [TestMethod]
        public void ValidationCheckTest()
        {     
            try
            {
                test.ValidationCheck();
            }
            catch(FormatException)
            {
                Assert.Fail(); ;
            }
        }

        [TestMethod]
        public void StressedLetterTest()
        {        
            string expected = "а";
            string actual = test.StressedLetter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SofteningTest()
        {
            string expected = "у";
            string actual = test.Softening("ю");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakeSoftYoteTest()
        {
            string expected = "йу";
            string actual = test.MakeSoftYote("ю");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VoicedToDeafTest()
        {
            string expected = "п";
            string actual = test.VoicedToDeaf("б");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeafToVoicedTest()
        {
            string expected = "б";
            string actual = test.DeafToVoiced("п");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HardToSoftTest()
        {
            string expected = "б'";
            string actual = test.HardToSoft("б");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckOutOfRangeTest()
        {
            bool expected = true;
            bool actual = test.CheckOutOfRange(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
