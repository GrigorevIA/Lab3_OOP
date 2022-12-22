using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFigures
{
    public class Square : Rectangle
    {
        public static new int count = 0;
        public Square(int x, int y, int width)
        {
            this.x = x;
            this.y = y; 
            this.width = width;
            if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                ShapeContainer.SquaresList.Add(this);
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
                g.FillRectangle(brush, x, y, width, width);
                g.DrawRectangle(pen, x, y, width, width);
                pictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        public void ResizeSquare(int width)
        {
            try
            {
                if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + width > pictureBox.Height))
                {
                    this.width = width;
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
        public void DeleteF(Square figure, bool flag)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, x, y, width, width);
            ShapeContainer.SquaresList.Remove(figure);
            ClearMap();
            foreach (Figure f in ShapeContainer.SquaresList)
            {
                f.Draw();
            }
            if (flag != true)
            {
                ShapeContainer.SquaresList.Add(figure);
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
