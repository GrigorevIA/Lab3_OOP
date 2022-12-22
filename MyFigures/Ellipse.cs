using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Ellipse : Figure
    {
        public static int count = 0;
        public Ellipse() { }
        public Ellipse(int x, int y, int width, int height) : base(x, y, width, height) 
        {
            if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                ShapeContainer.EllipsesList.Add(this);
                number = count;
                count++;
            }
            else
            {
                throw new Exception("Фигура выходит за границы");
            }
        }

        public override void Draw()
        {
            try
            {
                Graphics g = Graphics.FromImage(bitmap);
                SolidBrush brush = new SolidBrush(Color.Gray);
                g.FillEllipse(brush, x, y, width, height);
                g.DrawEllipse(pen, x, y, width, height);
                pictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }
        public void ResizeEll(int width, int height)
        {
            try
            {
                if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
                {
                    this.width = width; this.height = height;
                    DeleteF(this, false);
                    Draw();
                }
                else
                {
                    throw new Exception("Фигура выходит за границы");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }
        public void DeleteF(Ellipse figure, bool flag)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, x, y, width, height);
            ShapeContainer.EllipsesList.Remove(figure);
            ClearMap();
            foreach (Figure f in ShapeContainer.EllipsesList)
            {
                f.Draw();
            }
            if (flag != true)
            {
                ShapeContainer.EllipsesList.Add(figure);
            }
            pictureBox.Image = bitmap;
        }

        public override void MoveTo(int x, int y)
        {
            try
            {
                if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
                {
                    this.x = x; this.y = y;
                    DeleteF(this, false);
                    Draw();
                }
                else
                {
                    throw new Exception("Фигура выходит за границы");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
