using System.Security.Cryptography;
using static Task1.Descipline;

namespace DesciplineTests
{
    [TestClass]
    public class TestClassDescipline
    {
        [TestMethod]
        public void TestCreditUnit()
        {

            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", 24, 52);
            //Act
            Task1.Descipline actual = new Task1.Descipline("math", 38, 38);
            //Assert
            Assert.AreEqual(expected.CreditUnit, actual.CreditUnit);
        }
    }
}