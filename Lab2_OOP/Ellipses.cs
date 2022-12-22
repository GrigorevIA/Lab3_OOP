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

namespace Lab3_OOP
{
    public partial class Ellipses : Form
    {
        private Button but;
        private Random rnd = new Random();
        private List<Ellipse> buf_EllipsesList = new List<Ellipse>();
        private Bitmap bitmap;
        public Ellipses(Button but)
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

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            but.Enabled = true;
            ShapeContainer.EllipsesList.Clear();
        }

        private void Button_Draw_Click(object sender, EventArgs e)
        {
            try
            {
                Ellipse Ell = new Ellipse(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text), int.Parse(height.Text));
                Ell.Draw();
                comboBox1.Items.Add(Ell);
                comboBox1.Items[comboBox1.FindStringExact(Ell.ToString())] = $"Фигура{Ell.number}";
                bitmap = new Bitmap(pictureBox1.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void Button_New_Cords_Click(object sender, EventArgs e)
        {
            try
            {
                Ellipse Ell = ShapeContainer.EllipsesList[comboBox1.SelectedIndex];
                Ell.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void Button_New_Size_Click(object sender, EventArgs e)
        {
            try
            {
                Ellipse Ell = ShapeContainer.EllipsesList[comboBox1.SelectedIndex];
                Ell.ResizeEll(int.Parse(new_width.Text), int.Parse(new_height.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Ellipse Ell = ShapeContainer.EllipsesList[comboBox1.SelectedIndex];
                ShapeContainer.EllipsesList.Remove(Ell);
                Ell.DeleteF(Ell, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.EllipsesList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.EllipsesList[i]);
                    comboBox1.Items[i] = $"Фигура{ShapeContainer.EllipsesList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void FormEllipses_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = true;
            Button_New_Cords.Enabled = true;
            Button_New_Size.Enabled = true;
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

                foreach (Ellipse Ellipse in ShapeContainer.EllipsesList)
                {
                    buf_EllipsesList.Add(Ellipse);
                }

                if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Gray.ToArgb())
                {
                    foreach (Ellipse Ellipse in buf_EllipsesList)
                    {
                        if (Ellipse.x < click.X && Ellipse.x + Ellipse.width > click.X && Ellipse.y < click.Y && Ellipse.y + Ellipse.height > click.Y)
                        {
                            Ellipse.MoveTo(rnd.Next(0, pictureBox1.Width - Ellipse.width - 1), rnd.Next(0, pictureBox1.Height - Ellipse.height - 1));
                        }
                    }
                }
            }
        }
    }
}
