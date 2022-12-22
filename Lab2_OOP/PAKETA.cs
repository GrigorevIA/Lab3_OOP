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
using static System.Windows.Forms.LinkLabel;

namespace Lab3_OOP
{
    public partial class PAKETA : Form
    {
        private Button but;
        private Random rnd = new Random();
        private List<Rocket> buf_RocksList = new List<Rocket>();
        private Bitmap bitmap;
        public PAKETA(Button but)
        {
            InitializeComponent();
            Figure.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Figure.pictureBox = pictureBox1;
            Figure.pen = new Pen(Color.Black, 3);
            this.but = but;
            for (int i = 0; i < ShapeContainer.RocketsList.Count; i++)
            {
                comboBox1.Items.Add(ShapeContainer.RocketsList[i]);
                comboBox1.Items[i] = $"Фигура {ShapeContainer.RocketsList[i].number}";
            }
            buttonDelete.Enabled = false;
            Button_New_Cords.Enabled = false;
            Button_New_Size.Enabled = false;
        }
        Point click;
        private void FormRockets_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            but.Enabled = true;
            ShapeContainer.RocketsList.Clear();
        }

        private void Button_Draw_Click(object sender, EventArgs e)
        {
            try
            {
                Rocket Rocket = new Rocket(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text), int.Parse(height.Text));
                Rocket.Draw();
                comboBox1.Items.Add(Rocket);
                comboBox1.Items[comboBox1.FindStringExact(Rocket.ToString())] = $"Фигура {Rocket.number}";
                bitmap = new Bitmap(pictureBox1.Image); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Button_New_Cords_Click(object sender, EventArgs e)
        {
            try
            {
                Rocket Rocket = ShapeContainer.RocketsList[comboBox1.SelectedIndex];
                ShapeContainer.RocketsList.Remove(Rocket);
                Rocket.DeleteF(Rocket, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.RocketsList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.RocketsList[i]);
                    comboBox1.Items[i] = $"Фигура {ShapeContainer.RocketsList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
            try
            {
                Rocket Rocket = new Rocket(int.Parse(new_X.Text), int.Parse(new_Y.Text),
                                               int.Parse(width.Text), int.Parse(height.Text));
                Rocket.Draw();
                comboBox1.Items.Add(Rocket);
                comboBox1.Items[comboBox1.FindStringExact(Rocket.ToString())] = $"Фигура {Rocket.number}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = true;
            Button_New_Cords.Enabled = true;
            Button_New_Size.Enabled = true;
        }

        private void Button_New_Size_Click(object sender, EventArgs e)
        {
            try
            {
                Rocket Rocket = ShapeContainer.RocketsList[comboBox1.SelectedIndex];
                Rocket.ResizeRocket(int.Parse(new_width.Text), int.Parse(new_height.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Rocket Rocket = ShapeContainer.RocketsList[comboBox1.SelectedIndex];
                ShapeContainer.RocketsList.Remove(Rocket);
                Rocket.DeleteF(Rocket, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < ShapeContainer.RocketsList.Count; i++)
                {
                    comboBox1.Items.Add(ShapeContainer.RocketsList[i]);
                    comboBox1.Items[i] = $"Фигура {ShapeContainer.RocketsList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
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


                if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Gray.ToArgb() || bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Blue.ToArgb())
                {
                    foreach (Rocket Rock in ShapeContainer.RocketsList)
                    {
                        buf_RocksList.Add(Rock);
                    }
                    foreach (Rocket rocket in buf_RocksList)
                    {
                        if (rocket.left_x < click.X && rocket.right_x > click.X && rocket.high_y < click.Y && rocket.low_y > click.Y)
                        {
                            Graphics g = Graphics.FromImage(bitmap);
                            
                            foreach (Triangle part in rocket.Rocket_parts)
                            {
                                g.FillPolygon(new SolidBrush(Color.Red), part.points);
                            }
                            if (bitmap.GetPixel(click.X, click.Y).ToArgb() == Color.Red.ToArgb())
                            {
                                foreach (Triangle part in rocket.Rocket_parts)
                                {
                                    g.FillPolygon(new SolidBrush(Color.White), part.points);
                                }
                                rocket.MoveTo(rnd.Next(1 - rocket.left_x, pictureBox1.Width - rocket.right_x - 1), rnd.Next(1 - rocket.high_y, pictureBox1.Height - rocket.low_y - 1));
                            }
                            else
                            {
                                foreach (Triangle part in rocket.Rocket_parts)
                                {
                                    g.FillPolygon(new SolidBrush(Color.White), part.points);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
