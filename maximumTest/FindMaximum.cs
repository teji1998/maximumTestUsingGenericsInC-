using System;
using System.Collections.Generic;
using System.Text;

namespace maximumTest
{
    public class FindMaximum
    {
        public int FindingMaximumIntegerValue(int firstValue, int secondValue, int thirdValue) 
        {
            int maximum = firstValue;
            if (secondValue.CompareTo(maximum) > 0)
                maximum = secondValue;
            if (thirdValue.CompareTo(maximum) > 0)
                maximum = thirdValue;
            return maximum;
        }

        public float FindingMaximumFloatValue(float firstValue, float secondValue, float thirdValue)
        {
            float maximum = firstValue;
            if (secondValue.CompareTo(maximum) > 0)
                maximum = secondValue;
            if (thirdValue.CompareTo(maximum) > 0)
                maximum = thirdValue;
            return maximum;
        }
    }
}
