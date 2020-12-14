using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxValue_UsingGeneric;
namespace FindMaxValTesting
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Givens the maximum number first position.
        /// </summary>        
        [TestMethod]
        public void GivenMaxNumber_FirstPosition()
        {
            int result = MaximumNumberCheck.MaximumIntegerNumber(40,20,30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }

        /// <summary>
        /// Givens the maximum number second position.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumber_SecondPosition()
        {
            int result = MaximumNumberCheck.MaximumIntegerNumber(10, 40, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }

    }
}
