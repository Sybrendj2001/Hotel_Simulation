using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel.Objects.MovingObjects;
using Hotel.Objects;

namespace UnitTestProject.TestObjects
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestPersonStairSpeed()
        {
            //Arrange
            Person expectedAwnser = new Person();
            float check = 5;

            //Act
            expectedAwnser.StairSpeed = 5;

            //Assert
            Assert.AreEqual(expectedAwnser.StairSpeed, check);
        }

        [TestMethod]
        public void TestPersonIsNotEntity()
        {
            //Arrange
            Person person = new Person();
            Entity expectedAwnser = new Person();

            //Act
            
            //Assert
            Assert.AreNotSame(person, expectedAwnser);
        }

        [TestMethod]
        public void TestPersonIsNotMovingObject()
        {

            //Arrange
            Person person = new Person();
            MovingObjects expectedAwnser = new Person();

            //Act

            //Assert
            Assert.AreNotSame(person, expectedAwnser);

        }
    }
}
