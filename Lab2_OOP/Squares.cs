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
    public partial class Squares : Form
    {
        private Button but;
        private Random rnd = new Random();
        private List<Square> buf_SquaresList = new List<Square>();
        private Bitmap bitmap;
        public Squares(Button but)
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
        private void FormSquares_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void Button_Draw_Click_1(object sender, EventArgs e)
        {
            try
            {
                Square Sq = new Square(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text));
                Sq.Draw();
                comboBox1.Items.Add(Sq);
                comboBox1.Items[comboBox1.FindStringExact(Sq.ToString())] = $"Sq{Sq.number}";
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
                Square Sq = ShapeContainer.SquaresList[comboBox1.SelectedIndex];
                ShapeContainer.SquaresList.Remove(Sq);
                Sq.DeleteF(Sq, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.SquaresList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.SquaresList[i]);
                    comboBox1.Items[i] = $"Фигура{ShapeContainer.SquaresList[i].number}";
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
                Square Sq = ShapeContainer.SquaresList[comboBox1.SelectedIndex];
                Sq.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
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
                Square Sq = ShapeContainer.SquaresList[comboBox1.SelectedIndex];
                Sq.ResizeSquare(int.Parse(new_width.Text));
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
            ShapeContainer.SquaresList.Clear();
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

                foreach (Square Square in ShapeContainer.SquaresList)
                {
                    buf_SquaresList.Add(Square);
                }

                if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Gray.ToArgb())
                {
                    foreach (Square Square in buf_SquaresList)
                    {
                        if (Square.x < click.X && Square.x + Square.width > click.X && Square.y < click.Y && Square.y + Square.width > click.Y)
                        {
                            Square.MoveTo(rnd.Next(0, pictureBox1.Width - Square.width - 1), rnd.Next(0, pictureBox1.Height - Square.width - 1));
                        }
                    }
                }
            }
        }
    }
}
