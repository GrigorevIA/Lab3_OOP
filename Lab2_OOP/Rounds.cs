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
    public partial class Rounds : Form
    {
        private Button but;
        private Random rnd = new Random();
        private List<Round> buf_RoundsList = new List<Round>();
        private Bitmap bitmap;
        public Rounds(Button but)
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
        private void FormRounds_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }



        private void Button_Draw_Click_1(object sender, EventArgs e)
        {
            try
            {
                Round Ro = new Round(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text));
                Ro.Draw();
                comboBox1.Items.Add(Ro);
                comboBox1.Items[comboBox1.FindStringExact(Ro.ToString())] = $"Фигура{Ro.number}";
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
                Round Ro = ShapeContainer.RoundsList[comboBox1.SelectedIndex];
                ShapeContainer.RoundsList.Remove(Ro);
                Ro.DeleteF(Ro, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.RoundsList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.RoundsList[i]);
                    comboBox1.Items[i] = $"Фигура{ShapeContainer.RoundsList[i].number}";
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
                Round Ro = ShapeContainer.RoundsList[comboBox1.SelectedIndex];
                Ro.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
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
                Round Ro = ShapeContainer.RoundsList[comboBox1.SelectedIndex];
                Ro.ResizeRound(int.Parse(new_width.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошипка");
            }
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            Close();
            but.Enabled = true;
            ShapeContainer.RoundsList.Clear();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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

                foreach (Round Round in ShapeContainer.RoundsList)
                {
                    buf_RoundsList.Add(Round);
                }

                if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Gray.ToArgb())
                {
                    foreach (Round Round in buf_RoundsList)
                    {
                        if (Round.x < click.X && Round.x + Round.diameter > click.X && Round.y < click.Y && Round.y + Round.diameter > click.Y)
                        {
                            Round.MoveTo(rnd.Next(0, pictureBox1.Width - Round.diameter - 1), rnd.Next(0, pictureBox1.Height - Round.diameter - 1));
                        }
                    }
                }
            }
        }
    }
}

