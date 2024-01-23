using Task1;

namespace TestDescipline
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrage
            Descipline expected = new Descipline("math", 50, 24);

            //Act
            Descipline actuale = new Descipline("mus", 24, 50);
           // Assert.AreEqual(expected, actuale);
            Assert.AreEqual(expected.CreditUnit, actuale.CreditUnit);
        }
    }
}