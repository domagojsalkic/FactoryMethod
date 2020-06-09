using System;
using FactoryMethod.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodUnitTest
{
    [TestClass]
    public class ICreatorTest
    {
        [TestMethod]
        public void CreatorGetsAnGeometryShapeEnumSquareAndShouldReturnSquareObject()
        {
            ICreator creator = new ShapeCreator();
            IShape shape = creator.CreateShape(GeometryShape.SQUARE, 10, 10, 100, 100);
            Assert.IsTrue(shape is Square);
        }        
        
        [TestMethod]
        public void CreatorGetsAnGeometryShapeEnumEllipseAndShouldReturnEllipseObject()
        {
            ICreator creator = new ShapeCreator();
            IShape shape = creator.CreateShape(GeometryShape.ELLIPSE, 10, 10, 100, 100);
            Assert.IsTrue(shape is Ellipse);
        }

        [TestMethod]
        public void AssertionFailedDialogShouldPopUpAndShapeMustBeNull()
        {
            ICreator creator = new ShapeCreator();
            IShape shape = creator.CreateShape(GeometryShape.NONE, 0, 0, 0, 0);
            Assert.IsTrue(shape is null);
        }
    }
}
