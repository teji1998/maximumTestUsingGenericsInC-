using System;
using System.Collections.Generic;
using System.Text;

namespace maximumTest
{
    public class FindMaximum
    {
        //
        public class GenericMaximum <T> where T : IComparable
        {
            
            public T firstValue, secondValue, thirdValue;

            /// <summary>
            /// Initializes a new instance of the <see cref="GenericMaximum{T}"/> class.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            public GenericMaximum(T firstValue, T secondValue, T thirdValue)
            {
                this.firstValue = firstValue;
                this.secondValue = secondValue;
                this.thirdValue = thirdValue;
            }

            /// <summary>
            /// Finding the maximum value.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            /// <returns></returns>
            public static T FindingMaximumValue(T firstValue, T secondValue, T thirdValue)
            {
                T maximum = firstValue;
                if (secondValue.CompareTo(maximum) > 0)
                    maximum = secondValue;
                if (thirdValue.CompareTo(maximum) > 0)
                    maximum = thirdValue;
                return maximum;
            }

            /// <summary>
            /// Maximum value is returned in this method
            /// </summary>
            /// <returns></returns>
            public T MaximumMethod()
            {
                T maxValue = GenericMaximum<T>.FindingMaximumValue(this.firstValue, this.secondValue, this.thirdValue);
                return maxValue;
            }
        }
        
    }
}
