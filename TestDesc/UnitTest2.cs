using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1;

namespace TestDesc
{
    [TestClass]
    public class TestClassDisciplineArray
    {
        [TestMethod]
        public void TestCreateEmptyDisciplineArray()
        {
            //Arrange
            Task1.DisciplineArray expected = new Task1.DisciplineArray();
            //Act
            
            //Assert
            Assert.AreEqual(expected.Length, 0);
        }

        [TestMethod]
        public void TestCreateRandomFilledDisciplineArray()
        {
            //Arrange
            Task1.DisciplineArray expected = new Task1.DisciplineArray(4);
            //Act

            //Assert
            Assert.AreEqual(expected.Length, 4);
        }

        [TestMethod]
        public void TestCreateUserFilledDisciplineArray()
        {
            //Arrange
            Task1.Discipline dis1 = new Discipline("cute", 24, 38);
            Task1.Discipline dis2 = new Discipline("pretty", 54, 38);
            Task1.DisciplineArray expected = new Task1.DisciplineArray(dis1, dis2);
            //Act
            string actual = "Discipline cute has 24 Contact hours and 38 Self hours.\nDiscipline pretty has 54 Contact hours and 38 Self hours.\n";
            //Assert
            Assert.AreEqual(expected.ToString(), actual);
        }

        [TestMethod]
        public void TestAddNewDisciplineToDisciplineArray()
        {
            //Arrange
            Task1.Discipline dis1 = new Discipline("cute", 24, 38);
            Task1.Discipline dis2 = new Discipline("pretty", 54, 38);
            Task1.DisciplineArray expected = new Task1.DisciplineArray(dis1);
            expected.Add(dis2);
            //Act
            string actual = "Discipline cute has 24 Contact hours and 38 Self hours.\nDiscipline pretty has 54 Contact hours and 38 Self hours.\n";
            //Assert
            Assert.AreEqual(expected.ToString(), actual);
        }

        [TestMethod]
        public void TestGetElementByIndexDisciplineArray()
        {
            //Arrange
            //Act
            Task1.Discipline dis1 = new Discipline("cute", 24, 38);
            Task1.Discipline dis2 = new Discipline("pretty", 54, 38);
            Task1.DisciplineArray expected = new Task1.DisciplineArray(dis1, dis2);
            
            //Assert
            Assert.AreEqual(expected[1].ToString(), dis2.ToString());
        }

        [TestMethod]
        public void TestSetElementByIndexDisciplineArray()
        {
            //Arrange
            //Act
            Task1.Discipline dis1 = new Discipline("cute", 24, 38);
            Task1.Discipline dis2 = new Discipline("pretty", 54, 38);
            Task1.DisciplineArray expected = new Task1.DisciplineArray(dis1);
            expected[0] = dis2;
            //Assert
            Assert.AreEqual(expected[0].ToString(), dis2.ToString());
        }

        [TestMethod]
        public void TestCloneDisciplineArray()
        {
            //Arrange
            //Act
            Task1.Discipline dis1 = new Discipline("cute", 24, 38);
            Task1.Discipline dis2 = new Discipline("pretty", 54, 38);
            Task1.DisciplineArray actual = new Task1.DisciplineArray(dis1, dis2);
            Task1.DisciplineArray expected = (DisciplineArray)actual.Clone();
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void TestEnumeratorDisciplineArray()
        {
            //Arrange
            //Act
            Task1.Discipline dis1 = new Discipline("cute", 24, 38);
            Task1.Discipline dis2 = new Discipline("pretty", 54, 38);
            Task1.DisciplineArray actual = new Task1.DisciplineArray(dis1, dis2);
            Task1.DisciplineArray expected = new DisciplineArray();
            foreach (Discipline dis in actual)
            {
                expected.Add(dis);
            }
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }
}
