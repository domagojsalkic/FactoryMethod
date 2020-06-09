using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod.Models
{
    public class Square : IShape
    {
        public Square(int x, int y, int width, int height)
        {
            rectangle.X = x;
            rectangle.Y = y - height;
            rectangle.Width = width;
            rectangle.Height = height;
            myBrush = new SolidBrush(Color.Red);
            myPen = new Pen(Color.Black, 2);
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(myPen, rectangle);
            graphics.FillRectangle(myBrush, rectangle);
        }

        public readonly Pen myPen;
        public readonly Brush myBrush;
        public readonly Rectangle rectangle;
    }
}
