using Microsoft.VisualStudio.TestTools.UnitTesting;

using MSTest_Example.Utilities;

namespace MSTest
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Factorial_Value3_Return6()
        {
            int value = 3;
            int result = Math.Factorial(value);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Factorial_Value10_Return1()
        {
            int value = 10;
            int result = Math.Factorial(value);

            Assert.AreEqual(1, result, "Value should be at 1");
        }
    }
}
