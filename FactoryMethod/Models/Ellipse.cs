using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    public class Ellipse : Shape
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

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(myPen,rectangle);
            graphics.FillEllipse(myBrush,rectangle);
        }

        private readonly Pen myPen;
        private readonly Brush myBrush;
        private readonly Rectangle rectangle;
    }
}
