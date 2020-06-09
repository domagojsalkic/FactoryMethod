using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryMethod.Models;

namespace FactoryMethod
{
    public partial class DrawingPanel : Panel
    {
        public DrawingPanel()
        {
            InitializeComponent();
        }

        public DrawingPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void DrawShape(GeometryShape geometryShape, int x, int y, int width, int height)
        {
            drawing.DrawShape(geometryShape,x,y,width,height);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            drawing.DrawShapes(e.Graphics);
            base.OnPaint(e);
        }

        Drawing drawing = new Drawing();
    }
}
