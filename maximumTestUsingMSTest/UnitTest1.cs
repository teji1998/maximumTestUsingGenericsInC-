using maximumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace maximumTestUsingMSTest
{


    [TestClass]
    public class UnitTest1
    {
        FindMaximum findMaximum;

        public UnitTest1 () {
            findMaximum = new FindMaximum();
        }
    
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtFirstPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = findMaximum.FindingMaximumIntegerValue(8, 3, 5);
            Assert.AreEqual(8, maximumInteger);
        }

        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtSecondPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = findMaximum.FindingMaximumIntegerValue(3, 8, 5);
            Assert.AreEqual(8, maximumInteger);
        }

        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtThirdPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = findMaximum.FindingMaximumIntegerValue(3, 5, 8);
            Assert.AreEqual(8, maximumInteger);
        }

        [TestMethod]
        public void givenThreeIntegers_WhenMaximumFloatNumberAtFirstPosition_ShouldReturnMaximumFloatNumber()
        {
            float maximumValue = findMaximum.FindingMaximumFloatValue(37.5f, 56.4f, 87.6f);
            Assert.AreEqual(87.6f, maximumValue);
        }


    }
}
