using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel.Objects.MovingObjects;
using Hotel.Objects;

namespace UnitTestProject.TestObjects
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void TestUserIsNotPerson()
        {

            //Arrange
            User user = new User();
            Person ExpecectedAwnser = new User();

            //Act

            //Assert
            Assert.AreNotSame(user, ExpecectedAwnser);
        }

        [TestMethod]
        public void TestUserStairSpeedIsPersonStairSpeed()
        {

            //Arrange
            User user = new User();
            Person ExpecectedAwnser = new User();

            //Act
            user.StairSpeed = 5;
            ExpecectedAwnser.StairSpeed = 5;

            //Assert
            Assert.AreEqual(user.StairSpeed, ExpecectedAwnser.StairSpeed);
        }

        [TestMethod]
        public void TestUserIsNotEntity()
        {
            //Arrange
            User person = new User();
            Entity expectedAwnser = new User();

            //Act

            //Assert
            Assert.AreNotSame(person, expectedAwnser);
        }

        [TestMethod]
        public void TestUserIsNotMovingObject()
        {

            //Arrange
            User person = new User();
            MovingObjects expectedAwnser = new User();

            //Act

            //Assert
            Assert.AreNotSame(person, expectedAwnser);

        }

        [TestMethod]
        public void TestUserStairSpeed()
        {
            //Arrange
            User expectedAwnser = new User();
            float check = 5;

            //Act
            expectedAwnser.StairSpeed = 5;

            //Assert
            Assert.AreEqual(expectedAwnser.StairSpeed, check);
        }
    }
}
