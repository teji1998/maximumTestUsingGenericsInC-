﻿using System;
using System.Collections.Generic;
using System.Text;

namespace maximumTest
{
    public class FindMaximum
    {
        
        public class GenericMaximum <T> where T : IComparable
        {
            
            public T[] array;

            /// <summary>
            /// Initializes a new instance of the <see cref="GenericMaximum{T}"/> class.
            /// </summary>
            /// <param name="array">The array.</param>
            public GenericMaximum(T[] array)
            {
                this.array = array;
            }

            /// <summary>
            /// Sorts the data present in the array.
            /// </summary>
            /// <param name="data">The data.</param>
            /// <returns></returns>
            public T[] Sort(T[] data)
            {
                Array.Sort(data);
                return data;
            }

            /// <summary>
            /// Maximum value from sorted array is returned.
            /// </summary>
            /// <param name="data">The data.</param>
            /// <returns></returns>
            public T MaximumValueInArrayMethod(params T[] data)
            {
                T[] sortedArray = Sort(this.array);
                return sortedArray[sortedArray.Length - 1];
            }

            /// <summary>
            /// Maximum value is returned.
            /// </summary>
            /// <returns></returns>
            public T MaximumValue()
            {
                var maxValue = MaximumValueInArrayMethod(this.array);
                return maxValue;
            }

            public void PrintMaximumValue()
            {
                var maxValue = MaximumValueInArrayMethod(this.array);
                Console.WriteLine("Maximum value is : " + maxValue);
            }
        }
        
    }
}
