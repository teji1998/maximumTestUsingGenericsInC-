using System;
using System.Collections.Generic;
using System.Text;

namespace maximumTest
{
    public class FindMaximum
    {
        public int FindingMaximum(int firstValue, int secondValue, int thirdValue) 
        {
            int maximum = firstValue;
            if (secondValue.CompareTo(maximum) > 0)
                maximum = secondValue;
            if (thirdValue.CompareTo(maximum) > 0)
                maximum = thirdValue;
            return maximum;
        }
    }
}
