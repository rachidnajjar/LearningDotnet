using UnitTestHelloWorld;
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelloWorld.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMain()
        {
            string expected = "Hello World!";
            string result;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);
                result = sw.ToString().Trim();
            }

            Assert.AreEqual(expected, result);
        }
    }
}
