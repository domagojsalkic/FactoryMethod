using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryMethod.Models;

namespace FactoryMethod
{
    public partial class FactoryMethodShapeCreator : Form
    {
        public FactoryMethodShapeCreator()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(xPos.Text, out x)
                && int.TryParse(yPos.Text, out y)
                && int.TryParse(widthPos.Text, out width)
                && int.TryParse(heightPos.Text, out height)
                && (squareBtn.Checked || ellipseBtn.Checked))
            {
                if (squareBtn.Checked)
                {
                    drawingPanel.DrawShape(GeometryShape.SQUARE, x, y, width, height);
                }
                else if(ellipseBtn.Checked)
                {
                    drawingPanel.DrawShape(GeometryShape.ELLIPSE, x, y, width, height);
                }
            }
        }

        private int x;
        private int y;
        private int width;
        private int height;
    }
}
