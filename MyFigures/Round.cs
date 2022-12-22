using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Round : Ellipse
    {
        public static new int count = 0;
        public int diameter;
        public Round(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            diameter = radius*2;
            if (!(x < 0 || y < 0 || x + diameter > pictureBox.Width || y + diameter > pictureBox.Height))
            {
                ShapeContainer.RoundsList.Add(this);
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
                g.FillEllipse(brush, x, y, diameter, diameter);
                g.DrawEllipse(pen, x, y, diameter, diameter);
                pictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        public void ResizeRound(int radius)
        {
            try
            {
                if (!(x < 0 || y < 0 || x + radius * 2 > pictureBox.Width || y + radius * 2 > pictureBox.Height))
                {
                    diameter = radius * 2;
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
        public void DeleteF(Round figure, bool flag)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, x, y, width, height);
            ShapeContainer.RoundsList.Remove(figure);
            ClearMap();
            foreach (Figure f in ShapeContainer.RoundsList)
            {
                f.Draw();
            }
            if (flag != true)
            {
                ShapeContainer.RoundsList.Add(figure);
            }
            pictureBox.Image = bitmap;
        }

        public override void MoveTo(int x, int y)
        {
            try
            {
                if (!(x < 0 || y < 0 || x + diameter > pictureBox.Width || y + diameter > pictureBox.Height))
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
