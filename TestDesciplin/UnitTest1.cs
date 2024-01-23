using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1;

namespace TestDesciplin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Descipline expected = new Descipline("math", 50, 24);

            //Act
            Descipline actuale = new Descipline("mus", 24, 50);
            // Assert.AreEqual(expected, actuale);
            Assert.AreEqual(expected.GetCreditUnit(), actuale.GetCreditUnit());
            Assert.IsFalse(expected != actuale);
            Assert.IsFalse(expected < actuale);
            Assert.IsFalse(expected > actuale);
            Assert.IsTrue(expected == actuale);
            Assert.IsTrue(expected <= actuale);
            Assert.IsTrue(expected >= actuale);
            int b = actuale;
            Assert.AreEqual(12, b);
        }
    }
}
