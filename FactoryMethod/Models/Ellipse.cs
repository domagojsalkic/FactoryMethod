using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    public class Ellipse : IShape
    {
        public Ellipse(int x, int y, int width, int height)
        {
            rectangle.X = x;
            rectangle.Y= y;
            rectangle.Width = width;
            rectangle.Height = height;
            myBrush = new SolidBrush(Color.Blue);
            myPen = new Pen(Color.Black, 2);
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(myPen,rectangle);
            graphics.FillEllipse(myBrush,rectangle);
        }

        public readonly Pen myPen;
        public readonly Brush myBrush;
        public readonly Rectangle rectangle;
    }
}
