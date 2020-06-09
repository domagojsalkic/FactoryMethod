using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    public class ShapeCreator : ICreator
    {
        public IShape CreateShape(GeometryShape geometryShape, int x, int y, int width, int height)
        {
            switch (geometryShape)
            {
                case GeometryShape.ELLIPSE:
                    return new Ellipse(x,y,width,height);
                case GeometryShape.SQUARE:
                    return new Square(x,y,width,height);
                default:
                    Debug.Assert(false);
                    return null;
            }
        }
    }
}
