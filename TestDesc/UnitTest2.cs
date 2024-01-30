using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDesc
{
    [TestClass]
    public class TestClassDesciplineArray
    {
        [TestMethod]
        public void D()
        {
            //Arrange
            Task1.DesciplineArray expected = new Task1.DesciplineArray();
            //Act
            
            //Assert
            Assert.AreEqual(expected.Length, 0);
        } 
    }
}
