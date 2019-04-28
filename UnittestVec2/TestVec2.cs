using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel.vector;

namespace UnitTestProject
{
    [TestClass]
    public class TestVec2
    {
        [TestMethod]
        public void TestIfAwnserIsEqual()
        {
            //Arrange
            Vector2D vec2 = new Vector2D();
            int antwoord = 100;
            //Act
            vec2.X = 100;

            //Assert
            Assert.AreEqual(antwoord, vec2.X);
        }

        [TestMethod]
        public void Vec2ToPoint()
        {
            //arrange
            Point point = new Point(20,20);
            Vector2D antwoord;

            //act
            antwoord = point.ToVector2D();

            //assert
            Assert.AreEqual(antwoord.X, point.X);
        }
    }
}
