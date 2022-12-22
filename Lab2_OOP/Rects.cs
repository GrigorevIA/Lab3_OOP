using MyFigures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = MyFigures.Rectangle;

namespace Lab3_OOP
{
    public partial class Rects : Form
    {
        private Button but;
        private Random rnd = new Random();
        private List<Rectangle> buf_RectsList = new List<Rectangle>();
        private Bitmap bitmap;
        public Rects(Button but)
        {
            InitializeComponent();
            Figure.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Figure.pictureBox = pictureBox1;
            Figure.pen = new Pen(Color.Black, 3);
            this.but = but;
            buttonDelete.Enabled = false;
            Button_New_Cords.Enabled = false;
            Button_New_Size.Enabled = false;
        }
        Point click;
        private void FormRect_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }



        private void Button_Draw_Click_1(object sender, EventArgs e)
        {
            try
            {
                Rectangle Rect = new Rectangle(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text), int.Parse(height.Text));
                Rect.Draw();
                comboBox1.Items.Add(Rect);
                comboBox1.Items[comboBox1.FindStringExact(Rect.ToString())] = $"Фигура {Rect.number}";
                bitmap = new Bitmap(pictureBox1.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                Rectangle Rect = ShapeContainer.RectsList[comboBox1.SelectedIndex];
                ShapeContainer.RectsList.Remove(Rect);
                Rect.DeleteF(Rect, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.RectsList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.RectsList[i]);
                    comboBox1.Items[i] = $"Фигура {ShapeContainer.RectsList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void Button_New_Cords_Click_1(object sender, EventArgs e)
        {
            try
            {
                Rectangle Rect = ShapeContainer.RectsList[comboBox1.SelectedIndex];
                Rect.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void Button_New_Size_Click_1(object sender, EventArgs e)
        {
            try
            {
                Rectangle Rect = ShapeContainer.RectsList[comboBox1.SelectedIndex];
                Rect.ResizeRect(int.Parse(new_width.Text), int.Parse(new_height.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            buttonDelete.Enabled = true;
            Button_New_Cords.Enabled = true;
            Button_New_Size.Enabled = true;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            Close();
            but.Enabled = true;
            ShapeContainer.RectsList.Clear();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            setX.Text = click.X.ToString();
            setY.Text = click.Y.ToString();
            new_X.Text = click.X.ToString();
            new_Y.Text = click.Y.ToString();
            if (e.Button == MouseButtons.Right && bitmap != null)
            {
                bitmap = new Bitmap(pictureBox1.Image);
                foreach (Rectangle rect in ShapeContainer.RectsList)
                {
                    buf_RectsList.Add(rect);
                }

                if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Gray.ToArgb())
                {
                    foreach (Rectangle rect in buf_RectsList)
                    {
                        if (rect.x < click.X && rect.x + rect.width > click.X && rect.y < click.Y && rect.y + rect.height > click.Y)
                        {
                            rect.MoveTo(rnd.Next(0, pictureBox1.Width - rect.width - 1), rnd.Next(0, pictureBox1.Height - rect.height - 1));
                        }
                    }
                }
            }
        }
    }
}
