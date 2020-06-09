using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    public class Drawing
    {
        public Drawing()
        {
            creator = new ShapeCreator();
            shapes = new List<IShape>();
        }

        public void DrawShape(GeometryShape geometryShape, int x, int y, int width, int height)
        {
            IShape shape = creator.CreateShape(geometryShape, x, y, width, height);
            if (shape != null)
            {
                shapes.Add(shape);
            }
            else
            {
                Debug.Assert(false);
            }
        }

        public void DrawShapes(Graphics graphics)
        {
            foreach(var shape in shapes)
            {
                shape.Draw(graphics);
            }
        }

        private ICreator creator;
        private List<IShape> shapes;
    }
}
