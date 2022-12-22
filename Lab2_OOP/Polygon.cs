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
    public partial class Polygon : Form
    {
        private Button but;
        PictureBox pictureBox;
        private Point[] points;
        private int number = 0;
        public Polygon(Button but, PictureBox pictureBox)
        {
            InitializeComponent();
            this.but = but;
            this.pictureBox = pictureBox;
            for (int i = 0; i < FiguresContainer.PolygonsList.Count; i++)
            {
                comboBox1.Items.Add(FiguresContainer.PolygonsList[i]);
                comboBox1.Items[i] = $"Pol{FiguresContainer.PolygonsList[i].number}";
            }
            CancelPoints.Enabled = false;
            AddPoint.Enabled = false;
            Draw.Enabled = false;
            Delete.Enabled = false;
            ChangeCords.Enabled = false;
        }
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
        }

        private void ConfirmNum_Click(object sender, EventArgs e)
        {
            try 
            {
                int pointsNum = int.Parse(PointsNum.Text);
                if (pointsNum < 3)
                {
                    throw new Exception("Количество точек должно быть три и больше");
                }
                points = new Point[pointsNum];
                PointsNum.Enabled = false;
                CancelPoints.Enabled = true;
                AddPoint.Enabled = true;
                ConfirmNum.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ашипка");
            }
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(X_cord.Text);
                int y = int.Parse(Y_cord.Text);
                if (!(x < 0 || y < 0 || x > pictureBox.Width || y > pictureBox.Height))
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
                else { throw new Exception("Точка должна быть в пределах холста"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ашипка");
            }
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Polygon pol = new MyFigures.Polygon(points);
                pol.Draw();
                comboBox1.Items.Add(pol);
                comboBox1.Items[comboBox1.FindStringExact(pol.ToString())] = $"Pol{pol.number}";
                CancelPoints_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ашипка");
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
                MyFigures.Polygon pol = FiguresContainer.PolygonsList[comboBox1.SelectedIndex];
                FiguresContainer.PolygonsList.Remove(pol);
                pol.DeleteF(pol, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < FiguresContainer.PolygonsList.Count; i++)
                {
                    comboBox1.Items.Add(FiguresContainer.PolygonsList[i]);
                    comboBox1.Items[i] = $"Pol{FiguresContainer.PolygonsList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }

        private void ChangeCords_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Polygon pol = FiguresContainer.PolygonsList[comboBox1.SelectedIndex];
                pol.MoveTo(int.Parse(dX.Text), int.Parse(dY.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ашипка");
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
                MessageBox.Show($"{ex.Message}", "Ашипка");
            }
        }
    }
}

