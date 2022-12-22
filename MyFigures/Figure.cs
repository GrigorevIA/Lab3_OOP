using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace MyFigures
{
    abstract public class Figure
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int number;
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;
        public Figure() { }
        public Figure(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        public void ClearMap()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.WhiteSmoke);
            pictureBox.Image = bitmap;
        }
    }

}
