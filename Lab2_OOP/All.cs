using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFigures;

namespace Lab3_OOP
{
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
            
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Rects formRect = new Rects(buttonRectangle);
            formRect.Show();
            buttonRectangle.Enabled = false;
            ShapeContainer.RectsList.Clear();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Squares formSquares = new Squares(buttonSquare);
            formSquares.Show();
            buttonSquare.Enabled = false;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Ellipses formEllipses = new Ellipses(buttonEllipse);
            formEllipses.Show();
            buttonEllipse.Enabled = false;
        }

        private void buttonRound_Click(object sender, EventArgs e)
        {
            Rounds formRounds = new Rounds(buttonRound);
            formRounds.Show();
            buttonRound.Enabled = false;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            Polygons formPolygon = new Polygons(Polygon);
            formPolygon.Show();
            Polygon.Enabled = false;

        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            Triangles formTriangle = new Triangles(Triangle);
            formTriangle.Show();
            Triangle.Enabled = false;
        }

        private void Rocket_Click(object sender, EventArgs e)
        {
            PAKETA formRocket = new PAKETA(Rocket);
            formRocket.Show();
            Rocket.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Figure.bitmap);
            g.Clear(Color.WhiteSmoke);
            Figure.pictureBox.Image = Figure.bitmap;
        }
    }
}
