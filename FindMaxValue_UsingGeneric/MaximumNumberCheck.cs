using System;

namespace FindMaxValue_UsingGeneric
{
    public class MaximumNumberCheck
    {
        /// <summary>
        /// Testing MaxNumber.
        /// </summary>
        /// <param name="first">First Value</param>
        /// <param name="second">Second Value</param>
        /// <param name="third">Third Value</param>
        /// <exception cref="Exception">First Second and Third Values are same</exception>
        
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("First,Second and Third Values Same...");
        }

        /// <summary>
        /// Testing MaxNumber.
        /// </summary>
        /// <param name="first">First Value</param>
        /// <param name="second">Second Value</param>
        /// <param name="third">Third Value</param>
        /// <exception cref="Exception">First Second and Third Values are same</exception>

        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("First,Second and Third Values Same...");
        }
    }
}
