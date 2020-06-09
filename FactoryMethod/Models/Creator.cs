using System.Windows.Forms;

namespace FactoryMethod.Models
{
    public enum GeometryShape
    {
        SQUARE,
        ELLIPSE
    }

    public interface ICreator
    {
        Shape CreateShape(GeometryShape geometryShape, int x, int y,int width, int height);
    }
}