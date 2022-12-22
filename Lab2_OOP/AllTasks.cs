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
    public partial class AllTasks : Form
    {
        public AllTasks()
        {
            InitializeComponent();
            Figure.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Figure.pictureBox = pictureBox1;
            Figure.pen = new Pen(Color.Black, 3);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Rect formRect = new Rect(buttonRectangle);
            formRect.Show();
            buttonRectangle.Enabled = false;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Square formSquares = new Square(buttonSquare);
            formSquares.Show();
            buttonSquare.Enabled = false;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Ellipse formEllipses = new Ellipse(buttonEllipse);
            formEllipses.Show();
            buttonEllipse.Enabled = false;
        }

        private void buttonRound_Click(object sender, EventArgs e)
        {
            Round formRounds = new Round(buttonRound);
            formRounds.Show();
            buttonRound.Enabled = false;
        }

        private void button_All_Clear_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Figure.bitmap);
            g.Clear(Color.WhiteSmoke);
            Figure.pictureBox.Image = Figure.bitmap;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            Polygon formPolygon = new Polygon(Polygon, pictureBox1);
            formPolygon.Show();
            Polygon.Enabled = false;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            Triangle formTriangle = new Triangle(Triangle, pictureBox1);
            formTriangle.Show();
            Triangle.Enabled = false;
        }

        private void Rocket_Click(object sender, EventArgs e)
        {
            RAKETA formRocket = new RAKETA(Rocket);
            formRocket.Show();
            Rocket.Enabled = false;
        }
    }
}
