using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloUnitTest.Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Fibonacci_GetNthTerm_Input2_AssertResult1()
        {
            //Arrange
            int n = 2;
            int expected = 1;

            //Act
            Fibonacci fibonacci = new Fibonacci();
            int result = fibonacci.GetNthTerm(n);

            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
