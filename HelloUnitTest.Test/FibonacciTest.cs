using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloUnitTest.Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Fibonacci_GetTerm_Input0_AssertResult0()
        {
            //Arrange
            int n = 0;
            int expected = 0;

            //Act
            var math = new Math();
            Fibonacci fibonacci = new Fibonacci(math);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fibonacci_GetTerm_Input1_AssertResult1()
        {
            //Arrange
            int n = 1;
            int expected = 1;

            //Act
            var math = new Math();
            Fibonacci fibonacci = new Fibonacci(math);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fibonacci_GetTerm_Input2_AssertResult1()
        {
            //Arrange
            int n = 2;
            int expected = 1;

            //Act
            var math = new Math();
            Fibonacci fibonacci = new Fibonacci(math);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fibonacci_GetTerm_Input3_AssertResult2()
        {
            //Arrange
            int n = 3;
            int expected = 2;

            //Act
            var math = new Math();
            Fibonacci fibonacci = new Fibonacci(math);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Fibonacci_GetTerm_Input4_AssertResult3()
        {
            //Arrange
            int n = 4;
            int expected = 3;

            //Act
            var math = new Math();
            Fibonacci fibonacci = new Fibonacci(math);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Fibonacci_GetTerm_Input5_AssertResult5()
        {
            //Arrange
            int n = 5;
            int expected = 5;

            //Act
            var math = new Math();
            Fibonacci fibonacci = new Fibonacci(math);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Fibonacci_GetTerm_Input6_AssertResult8()
        {
            //Arrange
            int n = 6;
            int expected = 8;

            //Setup
            Mock<IMath> mockMath = new Mock<IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int a, int b) => a + b);

            //Act
            Fibonacci fibonacci = new Fibonacci(mockMath.Object);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(0,0)]
        [DataRow(1,1)]
        [DataRow(2,1)]
        [DataRow(3,2)]
        [DataRow(4,3)]
        [DataRow(5,5)]
        [DataRow(6,8)]
        [DataRow(7,13)]
        public void Fibonacci_GetTerm(int inputValue, int resultValue)
        {
            //Arrange
            int n = inputValue;
            int expected = resultValue;

            //Setup
            Mock<IMath> mockMath = new Mock<IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int a, int b) => a + b);

            //Act
            Fibonacci fibonacci = new Fibonacci(mockMath.Object);
            int result = fibonacci.GetTerm(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}
