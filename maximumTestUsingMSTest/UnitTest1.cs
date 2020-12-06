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

        /// <summary>
        /// Given three integers when having maximum integer at first position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtFirstPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = findMaximum.FindingMaximumIntegerValue(8, 3, 5);
            Assert.AreEqual(8, maximumInteger);
        }

        /// <summary>
        /// Given three integers when having maximum integer at second position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtSecondPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = findMaximum.FindingMaximumIntegerValue(3, 8, 5);
            Assert.AreEqual(8, maximumInteger);
        }

        /// <summary>
        /// Given three integers when having maximum integer at third position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtThirdPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = findMaximum.FindingMaximumIntegerValue(3, 5, 8);
            Assert.AreEqual(8, maximumInteger);
        }

        /// <summary>
        /// Given three float numbers when having maximum float number at first position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtFirstPosition_ShouldReturnMaximumFloatNumber()
        {
            float maximumValue = findMaximum.FindingMaximumFloatValue(87.6f, 37.5f, 56.4f);
            Assert.AreEqual(87.6f, maximumValue);
        }

        /// <summary>
        /// Given three float numbers when having maximum float number at second position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtSecondPosition_ShouldReturnMaximumFloatNumber()
        {
            float maximumValue = findMaximum.FindingMaximumFloatValue(37.5f, 85.6f, 56.4f);
            Assert.AreEqual(85.6f, maximumValue);
        }

        /// <summary>
        /// Given three float numbers when maximum float number at third position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtThirdPosition_ShouldReturnMaximumFloatNumber()
        {
            float maximumValue = findMaximum.FindingMaximumFloatValue(37.5f, 56.4f, 87.6f);
            Assert.AreEqual(87.6f, maximumValue);
        }

        [TestMethod]
        public void givenThreeStrings_WhenMaximumStringValueAtFirstPosition_ShouldReturnMaximumString()
        {
            string maximumValue = findMaximum.FindingMaximumStringValue("London", "Hogwarts", "Italy");
            Assert.AreEqual("London", maximumValue);
        }


    }
}
