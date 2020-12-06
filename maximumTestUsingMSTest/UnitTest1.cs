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
            int maximumInteger = findMaximum.FindingMaximum(8, 3, 5);
            Assert.AreEqual(8, maximumInteger);
        }

        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtSecondPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = findMaximum.FindingMaximum(3, 8, 5);
            Assert.AreEqual(8, maximumInteger);
        }
    }
}
