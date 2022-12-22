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
    public partial class Triangles : Form
    {
        private Button but;
        PictureBox pictureBox;
        private Point[] points = new Point[3];
        private int number = 0;
        private Random rnd = new Random();
        private List<Triangle> buf_TrisList = new List<Triangle>();
        private Bitmap bitmap;
        public Triangles(Button but)
        {
            InitializeComponent();
            Figure.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Figure.pictureBox = pictureBox1;
            Figure.pen = new Pen(Color.Black, 3);
            this.but = but;
            AddPoint.Enabled = true;
            Draw.Enabled = false;
            Delete.Enabled = false;
            ChangeCords.Enabled = false;
        }
        Point click;
        private void FormTriangles_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            but.Enabled = true;
            ShapeContainer.TrianglesList.Clear();
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(X_cord.Text);
                int y = int.Parse(Y_cord.Text);
                if (!(x < 0 || y < 0 || x > pictureBox1.Width || y > pictureBox1.Height))
                {
                    points[number] = new Point(x, y);
                    number++;
                    if (number == points.Length)
                    {
                        AddPoint.Enabled = false;
                        Draw.Enabled = true;
                        X_cord.Enabled = false;
                        Y_cord.Enabled = false;
                    }
                    else
                    {
                        Points_Label.Text = $"Координаты {number + 1}-ой точки:";
                    }
                }
                else { throw new Exception("Ошибка"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle Tri = new Triangle(points);
                Tri.Draw();
                comboBox1.Items.Add(Tri);
                comboBox1.Items[comboBox1.FindStringExact(Tri.ToString())] = $"Фигура {Tri.number}";
                CancelPoints_Click(sender, e);
                bitmap = new Bitmap(pictureBox1.Image);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete.Enabled = true;
            ChangeCords.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle Tri = ShapeContainer.TrianglesList[comboBox1.SelectedIndex];
                ShapeContainer.TrianglesList.Remove(Tri);
                Tri.DeleteF(Tri, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.TrianglesList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.TrianglesList[i]);
                    comboBox1.Items[i] = $"Фигура {ShapeContainer.TrianglesList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void ChangeCords_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle Tri = ShapeContainer.TrianglesList[comboBox1.SelectedIndex];
                Tri.MoveTo(int.Parse(dX.Text), int.Parse(dY.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void CancelPoints_Click(object sender, EventArgs e)
        {
            try
            {
                points = new Point[3]; number = 0;
                AddPoint.Enabled = true;
                Draw.Enabled = false;
                X_cord.Text = ""; Y_cord.Text = ""; X_cord.Enabled = true; Y_cord.Enabled = true;
                Points_Label.Text = "Координаты 1-ой точки:";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            X_cord.Text = click.X.ToString();
            Y_cord.Text = click.Y.ToString();
            dX.Text = click.X.ToString();
            dY.Text = click.Y.ToString();
            if (e.Button == MouseButtons.Right && bitmap != null)
            {
                bitmap = new Bitmap(pictureBox1.Image);

                foreach (Triangle Tri in ShapeContainer.TrianglesList)
                {
                    buf_TrisList.Add(Tri);
                }

                if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Gray.ToArgb())
                {
                    foreach (Triangle Tri in buf_TrisList)
                    {
                        if (Tri.x < click.X && Tri.r_x > click.X && Tri.y < click.Y && Tri.r_y > click.Y)
                        {
                            Graphics g = Graphics.FromImage(bitmap);
                            g.FillPolygon(new SolidBrush(Color.Red), Tri.points);
                            if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Red.ToArgb())
                            {
                                g.FillPolygon(new SolidBrush(Color.White), Tri.points);
                                Tri.MoveTo(rnd.Next(1 - Tri.x, pictureBox1.Width - Tri.r_x - 1), rnd.Next(1 - Tri.y, pictureBox1.Height - Tri.r_y - 1));
                            }
                        }
                    }
                }
            }
        }
    }
}
