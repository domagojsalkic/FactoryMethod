using System;
using FactoryMethod.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodUnitTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void CreateSquareX100Y100Width50Height50WithoutSquareCreatorFactoryMethod()
        {
            Square square = new Square(100,100,50,50);
            Assert.AreEqual(100, square.rectangle.X);
            Assert.AreEqual(50, square.rectangle.Y);
            Assert.AreEqual(50, square.rectangle.Width);
            Assert.AreEqual(50, square.rectangle.Height);
        }

        [TestMethod]
        public void CreateSquareX70Y100Width150Height70WithSquareCreatorFactoryMethod()
        {
            ICreator shapeCreator = new ShapeCreator();
            Shape square = shapeCreator.CreateShape(GeometryShape.SQUARE, 70, 100, 150, 70);
            Assert.AreEqual(70,((Square)square).rectangle.X);
            Assert.AreEqual(30,((Square)square).rectangle.Y);
            Assert.AreEqual(150,((Square)square).rectangle.Width);
            Assert.AreEqual(70,((Square)square).rectangle.Height);
        }
    }
}
