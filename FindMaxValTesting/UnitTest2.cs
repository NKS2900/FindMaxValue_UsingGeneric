using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxValue_UsingGeneric;
namespace FindMaxValTesting
{
    [TestClass]
    public class UnitTest2
    {

        /// <summary>
        /// Givens the maximum number first position.
        /// </summary>        
        [TestMethod]
        public void GivenMaxNumber_FirstPosition()
        {
            int result = GenericMaximum<int>.testMaximum(40, 20, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }

        /// <summary>
        /// Givens the maximum number second position.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumber_SecondPosition()
        {
            int result = GenericMaximum<int>.testMaximum(10, 40, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }

        /// <summary>
        /// Givens the maximum number third position.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumber_ThirdPosition()
        {
            int result = GenericMaximum<int>.testMaximum(10, 20, 40);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }

        /// <summary>
        /// Given the maximum float number first position.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatNumber_FirstPosition()
        {
            double result = GenericMaximum<double>.testMaximum(55.5, 20.2, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }

        /// <summary>
        /// Given the maximum float number second position.
        /// </summary>
        public void GivenMaxFloatNumber_SecondPosition()
        {
            double result = GenericMaximum<double>.testMaximum(20.2, 55.5, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }

        /// <summary>
        /// Given the maximum float number third position.
        /// </summary>
        public void GivenMaxFloatNumber_ThirdPosition()
        {
            double result = GenericMaximum<double>.testMaximum(20.2, 33.3, 55.5);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }

        /// <summary>
        /// Given the maximum string first position.
        /// </summary>
        public void GivenMaxString_FirstPosition()
        {
            string result = GenericMaximum<string>.testMaximum("Peach", "Apple", "Banana");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }

        /// <summary>
        /// Given the maximum string second position.
        /// </summary>
        public void GivenMaxString_SecondPosition()
        {
            string result = GenericMaximum<string>.testMaximum("Apple", "Peach", "Banana");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }

        /// <summary>
        /// Given the maximum string third position.
        /// </summary>
        public void GivenMaxString_ThirdPosition()
        {
            string result = GenericMaximum<string>.testMaximum("Apple", "Banana", "Peach");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }


        /// <summary>
        /// Test case to find max value using generic class and method
        /// </summary>
        [TestMethod]
        public void GiventIntegerArray_SortReturnMaxValue()
        {
            int[] arr = { 23, 35, 87, 233, 3, 44, 98 };
            GenericMaximum<int> max = new GenericMaximum<int>(arr);
            int result = max.MaxMethod();
            Assert.AreEqual(233, result);
        }

        /// <summary>
        /// Test case to find max value using generic class and method
        /// </summary>
        [TestMethod]
        public void GiventFloatArray_SortReturnMaxValue()
        {
            float[] arr = { 23.3f, 45.5f, 87.4f, 23.3f, 4.3f, 44.4f, 9.8f };
            GenericMaximum<float> max = new GenericMaximum<float>(arr);
            float result = max.MaxMethod();
            Assert.AreEqual(87.4f, result);
        }

        /// <summary>
        /// Test case to find max value using generic class and method
        /// </summary>
        [TestMethod]
        public void GiventStringArray_SortReturnMaxValue()
        {
            string[] arr = { "Apple", "Peach", "Banana" };
            GenericMaximum<string> max = new GenericMaximum<string>(arr);
            string result = max.MaxMethod();
            Assert.AreEqual("Peach", result);
        }
    }
}
