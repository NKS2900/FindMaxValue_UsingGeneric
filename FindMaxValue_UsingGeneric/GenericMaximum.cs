using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValue_UsingGeneric
{
    public class GenricMaximum<T> where T : IComparable
    {
        
        public T[] value;
        /// <summary>
        /// Initializes a new instance of the <see cref="GenricMaximum{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public GenricMaximum(T [] value)
        {           
            this.value = value;
        }

        /// <summary>
        /// Tests the maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns>maxValue</returns>
        /// <exception cref="Exception">firstValue,secondValue,thirdValue are same</exception>
        public static T testMaximum(T firstValue, T secondValue, T thirdValue) 
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,thirdValue are same");
        }

        /// <summary>
        /// Sorts the specified values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        /// <summary>
        /// Maximums the value.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T MaxValue( T[] values)
        {
            var sorted_value = Sort(values);
            return sorted_value[^1];
        }

        /// <summary>
        /// Maximum method.
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var Max = MaxValue(this.value);
            return Max;
        }
    }
}