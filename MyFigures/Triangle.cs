using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Triangle : Polygon
    {
        public static new int count = 0;
        public Triangle() { }
        public Triangle(Point[] points)
        {
            if (points.Length != 3)
            {
                throw new Exception("Ошибка");
            }
            this.points = points;
            x = points[0].X; y = points[0].Y;
            for (int i = 0; i < points.Length; i++)
            {
                if (x > points[i].X) { x = points[i].X; }
                if (x < 0) { throw new Exception("Ошибка"); }
                if (y > points[i].Y) { y = points[i].Y; }
                if (y < 0) { throw new Exception("Ошибка"); }
                if (r_x < points[i].X) { r_x = points[i].X; }
                if (r_x > pictureBox.Width) { throw new Exception("Ошибка"); }
                if (r_y < points[i].Y) { r_y = points[i].Y; }
                if (r_y > pictureBox.Height) { throw new Exception("Ошибка"); }
            }
            ShapeContainer.TrianglesList.Add(this);
            number = count;
            count++;
        }
        public Triangle(Point[] points, bool flag)
        {
            try
            {
                if (points.Length != 3)
                {
                    throw new Exception("Ошибка");
                }
                this.points = points;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
        public override void Draw()
        {
            try
            {
                Graphics g = Graphics.FromImage(bitmap);
                SolidBrush brush = new SolidBrush(Color.Gray);
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
                pictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
        public void Draw(bool f)
        {
            try
            {
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawPolygon(pen, points);
                pictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        public void DeleteF(Triangle figure, bool flag)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, x, y, width, height);
            ShapeContainer.TrianglesList.Remove(figure);
            ClearMap();
            foreach (Figure f in ShapeContainer.TrianglesList)
            {
                f.Draw();
            }
            if (flag != true)
            {
                ShapeContainer.TrianglesList.Add(figure);
            }
            pictureBox.Image = bitmap;
        }
        public override void MoveTo(int dx, int dy)
        {
            try
            {

                for (int i = 0; i < points.Length; i++)
                {
                    if (points[i].X + dx < pictureBox.Width && points[i].X + dx > 0 &&
                        points[i].Y + dy < pictureBox.Height && points[i].Y + dy > 0)
                    {
                        points[i].X += dx; points[i].Y += dy;
                    }
                    else
                    {
                        throw new Exception("Ошибка");
                    }
                }
                this.x += dx; this.y += dy;
                this.r_x += dx; this.r_y += dy;
                DeleteF(this, false);
                Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}

