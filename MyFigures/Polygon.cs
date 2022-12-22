using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Polygon : Figure
    {
        public Point[] points;
        public static int count = 0;
        public int r_x;
        public int r_y;
        public Polygon() { }
        public Polygon(Point[] points) 
        {
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
            number = count;
            count++;
            ShapeContainer.PolygonsList.Add(this);
        }
        public override void Draw()
        {
            try
            {
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawPolygon(pen, points);
                SolidBrush brush = new SolidBrush(Color.Gray);
                g.FillPolygon(brush, points);
                pictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
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
        public void DeleteF(Polygon figure, bool flag)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, x, y, width, height);
            ShapeContainer.PolygonsList.Remove(figure);
            ClearMap();
            foreach (Figure f in ShapeContainer.PolygonsList)
            {
                f.Draw();
            }
            if (flag != true)
            {
                ShapeContainer.PolygonsList.Add(figure);
            }
            pictureBox.Image = bitmap;
        }
    }
}
