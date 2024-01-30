using System.Threading.Tasks;

namespace TestDesciplines
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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