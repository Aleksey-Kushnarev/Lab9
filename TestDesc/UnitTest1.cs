using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Task1;


namespace TestDesc
{
    [TestClass]
    public class TestClassDiscipline
    {
        [TestMethod]
        public void TestDisciplineMakeObject()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline("math", -24, -52);
            //Act
            Task1.Discipline actual = new Task1.Discipline("math");
            //Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void TestDisciplineCreditUnit()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline("math", 24, 52);
            //Act
            Task1.Discipline actual = new Task1.Discipline("math", 38, 38);
            //Assert
            Assert.AreEqual(expected.CreditUnit, actual.CreditUnit);
        }

        [TestMethod]
        public void TestDisciplineComparisonIsGreater()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline("math", 48, 52);
            //Act
            Task1.Discipline actual = new Task1.Discipline("math", 38, 38);
            //Assert
            Assert.IsTrue(expected > actual);
            Assert.IsFalse(expected <= actual);
        }

        [TestMethod]
        public void TestDisciplineComparisonIsLess()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline("math", 12, 22);
            //Act
            Task1.Discipline actual = new Task1.Discipline("math", 38, 38);
            //Assert
            Assert.IsTrue(expected < actual);
            Assert.IsFalse(expected >= actual);
        }

        [TestMethod]
        public void TestDisciplineComparisonIsEqual()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline("math", 40, 22);
            //Act
            Task1.Discipline actual = new Task1.Discipline(expected);
            //Assert
            Assert.IsTrue(expected == actual);
            Assert.IsFalse(expected != actual);
        }

        [TestMethod]
        public void TestDisciplineToString()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline();
            //Act
            string actual = "Discipline default has 0 Contact hours and 0 Self hours.";
            //Assert
            Assert.AreEqual(expected.ToString(), actual);
        }

        [TestMethod]
        public void TestDisciplineToInt()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline("math", 40, 22);
            //Act
            int actual = 20;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDisciplineToDouble()
        {
            //Arrange
            Task1.Discipline expected = new Task1.Discipline("math", 20, 80);
            //Act
            double actual = 0.2d;
            //Assert
            Assert.AreEqual((double)expected, actual);
            
        }

        [TestMethod]
        public void TestDisciplineFailInc()
        {
            //Arrange
            Task1.Discipline expected = new Discipline("Pretty");
            Assert.ThrowsException<Exception>(()=>expected++);
        }

        [TestMethod]        
        public void TestDisciplineNotFailInc()
        {
            //Arrange
            Task1.Discipline expected = new Discipline("Pretty", 12, 24);
            //Act
            int actual = 7;
            Assert.AreEqual(expected++, actual);
        }
        [TestMethod]
        public void TestDisciplineFailAdd()
        {
            //Arrange
            Task1.Discipline expected = new Discipline("Pretty");

            Assert.ThrowsException<Exception>(() => expected+=7);
        }

        [TestMethod]
        public void TestDisciplineNotFailAdd()
        {
            //Arrange
            Task1.Discipline expected = new Discipline("Pretty", 12, 24);
            //Act
            int actual = 8;
            Assert.AreEqual(expected+4, actual);
        }

        [TestMethod]
        public void TestDisciplineInterestCalculation()
        {
            //Arrange
            Task1.Discipline expected = new Discipline("Pretty", 24, 24);
            //Act
            int actual = 50;
            Assert.AreEqual(!expected, actual);
        }
    }
}
