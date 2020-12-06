using/**/ maximumTest;
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
            int[] intArray = { 8, 5, 3 };
            FindMaximum.GenericMaximum<int> maximumValue = new FindMaximum.GenericMaximum<int>(intArray);
            int output = maximumValue.MaximumValue();
            Assert.AreEqual(8, output);
        }

        /// <summary>
        /// Given three integers when having maximum integer at second position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtSecondPosition_ShouldReturnMaximumInteger()
        {
            int[] intArray = { 5, 8, 3 };
            FindMaximum.GenericMaximum<int> maximumValue = new FindMaximum.GenericMaximum<int>(intArray);
            int output = maximumValue.MaximumValue();
            Assert.AreEqual(8, output);
        }

        /// <summary>
        /// Given three integers when having maximum integer at third position should return maximum integer.
        /// </summary>
        [TestMethod]
        public void givenThreeIntegers_WhenMaximumIntegerAtThirdPosition_ShouldReturnMaximumInteger()
        {
            int[] intArray = { 3, 5, 8 };
            FindMaximum.GenericMaximum<int> maximumValue = new FindMaximum.GenericMaximum<int>(intArray);
            int output = maximumValue.MaximumValue();
            Assert.AreEqual(8, output);
        }

        /// <summary>
        /// Givenmore than three integers when finding maximum integer should return maximum integer.
        /// </summary>
        [TestMethod]
        public void GivenMoreThanThreeIntegers_WhenFindingMaximumInteger_ShouldReturnMaximumInteger()
        {
            int[] intArray = { 3,5,8,56,78,24,17};
            FindMaximum.GenericMaximum<int> maximumValue = new FindMaximum.GenericMaximum<int>(intArray);
            int output = maximumValue.MaximumValue();
            Assert.AreEqual(78, output);
        }

        /// <summary>
        /// Given three float numbers when having maximum float number at first position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtFirstPosition_ShouldReturnMaximumFloatNumber()
        {
            float[] floatArray = { 87.6f, 37.5f, 56.4f };
            FindMaximum.GenericMaximum<float> maximumValue = new FindMaximum.GenericMaximum<float>(floatArray);
            float output = maximumValue.MaximumValue();
            Assert.AreEqual(87.6f, output);
        }

        /// <summary>
        /// Given three float numbers when having maximum float number at second position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtSecondPosition_ShouldReturnMaximumFloatNumber()
        {
            float[] floatArray = { 37.5f, 85.6f, 56.4f };
            FindMaximum.GenericMaximum<float> maximumValue = new FindMaximum.GenericMaximum<float>(floatArray);
            float output = maximumValue.MaximumValue();
            Assert.AreEqual(85.6f, output);
            
        }

        /// <summary>
        /// Given three float numbers when maximum float number at third position should return maximum float number.
        /// </summary>
        [TestMethod]
        public void givenThreeFloatNumbers_WhenMaximumFloatNumberAtThirdPosition_ShouldReturnMaximumFloatNumber()
        {
            float[] floatArray = { 37.5f, 56.4f, 87.6f };
            FindMaximum.GenericMaximum<float> maximumValue = new FindMaximum.GenericMaximum<float>(floatArray);
            float output = maximumValue.MaximumValue();
            Assert.AreEqual(87.6f, output);          
        }

        /// <summary>
        /// Given more than three float numbers when finding maximum float number should return maximum float number.
        /// </summary>
        [TestMethod]
        public void GivenMoreThanThreeFloatNumbers_WhenFindingMaximumFloatNumber_ShouldReturnMaximumFloatNumber()
        {
            float[] floatArray = { 37.5f, 56.4f, 87.6f, 54.7f, 32.9f, 66.6f };
            FindMaximum.GenericMaximum<float> maximumValue = new FindMaximum.GenericMaximum<float>(floatArray);
            float output = maximumValue.MaximumValue();
            Assert.AreEqual(87.6f, output);
        }

        /// <summary>
        /// Given three strings when the maximum string value at first position should return maximum string.
        /// </summary>
        [TestMethod]
        public void givenThreeStrings_WhenMaximumStringValueAtFirstPosition_ShouldReturnMaximumString()
        {
            string[] stringArray = { "London", "Hogwarts", "Italy" };
            FindMaximum.GenericMaximum<string> maximumValue = new FindMaximum.GenericMaximum<string>(stringArray);
            string output = maximumValue.MaximumValue();
            Assert.AreEqual("London", output);
        }

        /// <summary>
        /// Given three strings when the maximum string value at second position should return maximum string.
        /// </summary>
        [TestMethod]
        public void givenThreeStrings_WhenMaximumStringValueAtSecondPosition_ShouldReturnMaximumString()
        {
            string[] stringArray = { "Hogwarts", "London", "Italy" };
            FindMaximum.GenericMaximum<string> maximumValue = new FindMaximum.GenericMaximum<string>(stringArray);
            string output = maximumValue.MaximumValue();
            Assert.AreEqual("London", output);
        }


        /// <summary>
        /// Given three strings when the maximum string value at third position should return maximum string.
        /// </summary>
        [TestMethod]
        public void givenThreeStrings_WhenMaximumStringValueAtThirdPosition_ShouldReturnMaximumString()
        {
            string[] stringArray = { "Hogwarts", "Italy", "London" };
            FindMaximum.GenericMaximum<string> maximumValue = new FindMaximum.GenericMaximum<string>(stringArray);
            string output = maximumValue.MaximumValue();
            Assert.AreEqual("London", output);
        }

        /// <summary>
        /// Given more than three strings when finding maximum string should return maximum string.
        /// </summary>
        [TestMethod]
        public void GivenMoreThanThreeStrings_WhenFindingMaximumString_ShouldReturnMaximumString()
        {
            string[] stringArray = { "Hogwarts", "Italy", "London", "Denmark","Korea" };
            FindMaximum.GenericMaximum<string> maximumValue = new FindMaximum.GenericMaximum<string>(stringArray);
            string output = maximumValue.MaximumValue();
            Assert.AreEqual("London", output);
        }
    }
}
