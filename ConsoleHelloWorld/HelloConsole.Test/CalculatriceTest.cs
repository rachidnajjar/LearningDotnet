using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloConsole;

namespace HelloConsole.Test
{
    [TestClass]
    public class CalculatriceTest
    {
        [TestMethod]
        public void TestAdditionner()
        {
            int a = 12;
            int b = 9;
            int expected = 21;

            var calculatrice = new Calculatrice();
            int result = calculatrice.Additionner(a, b);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestSoustraire()
        {
            int a = 12;
            int b = 9;
            int expected = 3;

            var calculatrice = new Calculatrice();
            int result = calculatrice.Soustraire(a, b);

            Assert.AreEqual(result, expected);
        }
    }
}
