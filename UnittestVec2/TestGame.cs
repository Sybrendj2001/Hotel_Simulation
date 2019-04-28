using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel;

namespace UnitTest
{
    [TestClass]
    public class TestGame
    {
        [TestMethod]
        public void TestEmergencyBoolIsFalse()
        {
            //Arrange
            Game game = new Game();
            bool testbool;

            //Act
            testbool = game.EmergencyBool;

            //Assert
            Assert.IsFalse(testbool);

        }
    }
}
