using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Task1;


namespace TestDesc
{
    [TestClass]
    public class TestClassDescipline
    {
        [TestMethod]
        public void TestDesciplineMakeObject()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", -24, -52);
            //Act
            Task1.Descipline actual = new Task1.Descipline("math");
            //Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestDesciplineCreditUnit()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", 24, 52);
            //Act
            Task1.Descipline actual = new Task1.Descipline("math", 38, 38);
            //Assert
            Assert.AreEqual(expected.CreditUnit, actual.CreditUnit);
        }

        [TestMethod]
        public void TestDesciplineComparisonIsGreater()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", 48, 52);
            //Act
            Task1.Descipline actual = new Task1.Descipline("math", 38, 38);
            //Assert
            Assert.IsTrue(expected > actual);
            Assert.IsFalse(expected <= actual);
        }

        [TestMethod]
        public void TestDesciplineComparisonIsLess()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", 12, 22);
            //Act
            Task1.Descipline actual = new Task1.Descipline("math", 38, 38);
            //Assert
            Assert.IsTrue(expected < actual);
            Assert.IsFalse(expected >= actual);
        }

        [TestMethod]
        public void TestDesciplineComparisonIsEqual()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", 40, 22);
            //Act
            Task1.Descipline actual = new Task1.Descipline(expected);
            //Assert
            Assert.IsTrue(expected == actual);
            Assert.IsFalse(expected != actual);
        }

        [TestMethod]
        public void TestDesciplineToString()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline();
            //Act
            string actual = "Descipline default has 0 Contact hours and 0 Self hours.";
            //Assert
            Assert.AreEqual(expected.ToString(), actual);
        }

        [TestMethod]
        public void TestDesciplineToInt()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", 40, 22);
            //Act
            int actual = 20;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDesciplineToDouble()
        {
            //Arrange
            Task1.Descipline expected = new Task1.Descipline("math", 20, 80);
            //Act
            double actual = 0.2d;
            //Assert
            Assert.AreEqual((double)expected, actual);
            
        }

        [TestMethod]
        public void TestDesciplineFailInc()
        {
            //Arrange
            Task1.Descipline expected = new Descipline("Pretty");
            Assert.ThrowsException<Exception>(()=>expected++);
        }

        [TestMethod]        
        public void TestDesciplineNotFailInc()
        {
            //Arrange
            Task1.Descipline expected = new Descipline("Pretty", 12, 24);
            //Act
            int actual = 7;
            Assert.AreEqual(expected++, actual);
        }
        [TestMethod]
        public void TestDesciplineFailAdd()
        {
            //Arrange
            Task1.Descipline expected = new Descipline("Pretty");

            Assert.ThrowsException<Exception>(() => expected+=7);
        }

        [TestMethod]
        public void TestDesciplineNotFailAdd()
        {
            //Arrange
            Task1.Descipline expected = new Descipline("Pretty", 12, 24);
            //Act
            int actual = 8;
            Assert.AreEqual(expected+4, actual);
        }

        [TestMethod]
        public void TestDesciplineInterestCalculation()
        {
            //Arrange
            Task1.Descipline expected = new Descipline("Pretty", 24, 24);
            //Act
            int actual = 50;
            Assert.AreEqual(!expected, actual);
        }
    }
}
