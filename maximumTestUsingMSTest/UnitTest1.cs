using maximumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace maximumTestUsingMSTest
{


    [TestClass]
    public class UnitTest1
    {
       
        /// <summary>
        /// Given three integers when having maximum integer at first position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtFirstPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = new FindMaximum.GenericMaximum<int>(8, 3, 5).MaximumMethod();
            Assert.AreEqual(8, maximumInteger);
        }

        /// <summary>
        /// Given three integers when having maximum integer at second position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtSecondPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = new FindMaximum.GenericMaximum<int>(3, 8, 5).MaximumMethod();
            Assert.AreEqual(8, maximumInteger);
        }

        /// <summary>
        /// Given three integers when having maximum integer at third position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtThirdPosition_ShouldReturnMaximumInteger()
        {
            int maximumInteger = new FindMaximum.GenericMaximum<int>(3, 5, 8).MaximumMethod();
            Assert.AreEqual(8, maximumInteger);
        }

        /// <summary>
        /// Given three float numbers when having maximum float number at first position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtFirstPosition_ShouldReturnMaximumFloatNumber()
        {
            float maximumValue = new FindMaximum.GenericMaximum<float>(87.6f, 37.5f, 56.4f).MaximumMethod();
            Assert.AreEqual(87.6f, maximumValue);
        }

        /// <summary>
        /// Given three float numbers when having maximum float number at second position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtSecondPosition_ShouldReturnMaximumFloatNumber()
        {
            float maximumValue = new FindMaximum.GenericMaximum<float>(37.5f, 85.6f, 56.4f).MaximumMethod();
            Assert.AreEqual(85.6f, maximumValue);
        }

        /// <summary>
        /// Given three float numbers when maximum float number at third position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtThirdPosition_ShouldReturnMaximumFloatNumber()
        {
            float maximumValue = new FindMaximum.GenericMaximum<float>(37.5f, 56.4f, 87.6f).MaximumMethod();
            Assert.AreEqual(87.6f, maximumValue);
        }

        /// <summary>
        /// Given three strings when the maximum string value at first position should return maximum string.
        /// </summary>
        [TestMethod]
        public void givenThreeStrings_WhenMaximumStringValueAtFirstPosition_ShouldReturnMaximumString()
        {
            string maximumValue = new FindMaximum.GenericMaximum<string>("London", "Hogwarts", "Italy").MaximumMethod();
            Assert.AreEqual("London", maximumValue);
        }

        /// <summary>
        /// Given three strings when the maximum string value at second position should return maximum string.
        /// </summary>
        [TestMethod]
        public void givenThreeStrings_WhenMaximumStringValueAtSecondPosition_ShouldReturnMaximumString()
        {
            string maximumValue = new FindMaximum.GenericMaximum<string>("Hogwarts", "London", "Italy").MaximumMethod();
            Assert.AreEqual("London", maximumValue);
        }


        /// <summary>
        /// Given three strings when the maximum string value at third position should return maximum string.
        /// </summary>
        [TestMethod]
        public void givenThreeStrings_WhenMaximumStringValueAtThirdPosition_ShouldReturnMaximumString()
        {
            string maximumValue = new FindMaximum.GenericMaximum<string>("Hogwarts", "Italy", "London").MaximumMethod();
            Assert.AreEqual("London", maximumValue);
        }


    }
}
