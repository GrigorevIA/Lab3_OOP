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
    public partial class Polygons : Form
    {

        private Button but;
        PictureBox pictureBox;
        private Point[] points;
        private int number = 0;
        private Random rnd = new Random();
        private List<Polygon> buf_PolsList = new List<Polygon>();
        private Bitmap bitmap;
        public Polygons(Button but)
        {
            InitializeComponent();
            Figure.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Figure.pictureBox = pictureBox1;
            Figure.pen = new Pen(Color.Black, 3);
            this.but = but;
            CancelPoints.Enabled = false;
            AddPoint.Enabled = false;
            Draw.Enabled = false;
            Delete.Enabled = false;
            ChangeCords.Enabled = false;
        }
        Point click;
        private void FormPolygons_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            but.Enabled = true;
            ShapeContainer.PolygonsList.Clear();
        }

        private void ConfirmNum_Click(object sender, EventArgs e)
        {
            try 
            {
                int pointsNum = int.Parse(PointsNum.Text);
                if (pointsNum < 3)
                {
                    throw new Exception("Ошибка");
                }
                points = new Point[pointsNum];
                PointsNum.Enabled = false;
                CancelPoints.Enabled = true;
                AddPoint.Enabled = true;
                ConfirmNum.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
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
                Polygon pol = new Polygon(points);
                pol.Draw();
                comboBox1.Items.Add(pol);
                comboBox1.Items[comboBox1.FindStringExact(pol.ToString())] = $"Фигура {pol.number}";
                CancelPoints_Click(sender, e);
                bitmap = new Bitmap(pictureBox1.Image);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
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
                Polygon pol = ShapeContainer.PolygonsList[comboBox1.SelectedIndex];
                ShapeContainer.PolygonsList.Remove(pol);
                pol.DeleteF(pol, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.PolygonsList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.PolygonsList[i]);
                    comboBox1.Items[i] = $"Фигура {ShapeContainer.PolygonsList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void ChangeCords_Click(object sender, EventArgs e)
        {


            try
            {
                Polygon pol = ShapeContainer.PolygonsList[comboBox1.SelectedIndex];
                pol.MoveTo(int.Parse(dX.Text), int.Parse(dY.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void CancelPoints_Click(object sender, EventArgs e)
        {
            try
            {
                points = null; number = 0;
                PointsNum.Enabled = true; PointsNum.Text = "";
                CancelPoints.Enabled = false;
                AddPoint.Enabled = false;
                Draw.Enabled = false;
                ConfirmNum.Enabled = true;
                X_cord.Text = ""; Y_cord.Text = ""; X_cord.Enabled = true; Y_cord.Enabled = true;
                Points_Label.Text = "Координаты 1-ой точки:";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
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

                foreach (Polygon Pol in ShapeContainer.PolygonsList)
                {
                    buf_PolsList.Add(Pol);
                }

                if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Gray.ToArgb())
                {
                    foreach (Polygon Pol in buf_PolsList)
                    {
                        if (Pol.x < click.X && Pol.r_x > click.X && Pol.y < click.Y && Pol.r_y > click.Y)
                        {
                            Graphics g = Graphics.FromImage(bitmap);
                            g.FillPolygon(new SolidBrush(Color.Red), Pol.points);
                            if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Red.ToArgb())
                            {
                                g.FillPolygon(new SolidBrush(Color.White), Pol.points);
                                Pol.MoveTo(rnd.Next(1 - Pol.x, pictureBox1.Width - Pol.r_x - 1), rnd.Next(1 - Pol.y, pictureBox1.Height - Pol.r_y - 1));
                            }
                        }
                    }
                }
            }
        }
    }
}

