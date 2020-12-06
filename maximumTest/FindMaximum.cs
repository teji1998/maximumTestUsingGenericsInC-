using System;
using System.Collections.Generic;
using System.Text;

namespace maximumTest
{
    public class FindMaximum
    {
        /// <summary>
        /// Finding the maximum integer value.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        public int FindingMaximumIntegerValue(int firstValue, int secondValue, int thirdValue) 
        {
            int maximum = firstValue;
            if (secondValue.CompareTo(maximum) > 0)
                maximum = secondValue;
            if (thirdValue.CompareTo(maximum) > 0)
                maximum = thirdValue;
            return maximum;
        }

        /// <summary>
        /// Finding the maximum float value.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        public float FindingMaximumFloatValue(float firstValue, float secondValue, float thirdValue)
        {
            float maximum = firstValue;
            if (secondValue.CompareTo(maximum) > 0)
                maximum = secondValue;
            if (thirdValue.CompareTo(maximum) > 0)
                maximum = thirdValue;
            return maximum;
        }

        /// <summary>
        /// Finding the maximum string value.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        public string FindingMaximumStringValue(string firstValue, string secondValue, string thirdValue)
        {
            string maximum = firstValue;
            if (secondValue.CompareTo(maximum) > 0)
                maximum = secondValue;
            if (thirdValue.CompareTo(maximum) > 0)
                maximum = thirdValue;
            return maximum;
        }
    }
}
