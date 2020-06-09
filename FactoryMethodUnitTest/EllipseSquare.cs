using System;
using FactoryMethod.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodUnitTest
{
    [TestClass]
    public class EllipseSquare
    {
        [TestMethod]
        public void CreateEllipseX0Y10Width150Height50WithoutSquareCreatorFactoryMethod()
        {
            Ellipse ellipse = new Ellipse(0,10,150,50);
            Assert.AreEqual(0,ellipse.rectangle.X);
            Assert.AreEqual(10,ellipse.rectangle.Y);
            Assert.AreEqual(150,ellipse.rectangle.Width);
            Assert.AreEqual(50,ellipse.rectangle.Height);
        }
        
        [TestMethod]
        public void CreateEllipseX100Y40Width10Height50WithSquareCreatorFactoryMethod()
        {
            ICreator shapeCreator = new ShapeCreator();
            Shape ellipse = shapeCreator.CreateShape(GeometryShape.ELLIPSE,100,40,10,50);
            Assert.AreEqual(100,((Ellipse)ellipse).rectangle.X);
            Assert.AreEqual(40,((Ellipse)ellipse).rectangle.Y);
            Assert.AreEqual(10,((Ellipse)ellipse).rectangle.Width);
            Assert.AreEqual(50,((Ellipse)ellipse).rectangle.Height);
        }
    }
}
