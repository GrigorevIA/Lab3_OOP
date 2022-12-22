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
    public partial class Ellipse : Form
    {
        private Button but;
        public Ellipse(Button but)
        {
            InitializeComponent();
            this.but = but;
            for (int i = 0; i < FiguresContainer.EllipsesList.Count; i++)
            {
                comboBox1.Items.Add(FiguresContainer.EllipsesList[i]);
                comboBox1.Items[i] = $"Ell{FiguresContainer.EllipsesList[i].number}";
            }
            buttonDelete.Enabled = false;
            Button_New_Cords.Enabled = false;
            Button_New_Size.Enabled = false;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            but.Enabled = true;
        }

        private void Button_Draw_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Ellipse Ell = new MyFigures.Ellipse(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text), int.Parse(height.Text));
                Ell.Draw();
                comboBox1.Items.Add(Ell);
                comboBox1.Items[comboBox1.FindStringExact(Ell.ToString())] = $"Ell{Ell.number}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }

        private void Button_New_Cords_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Ellipse Ell = FiguresContainer.EllipsesList[comboBox1.SelectedIndex];
                Ell.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }

        private void Button_New_Size_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Ellipse Ell = FiguresContainer.EllipsesList[comboBox1.SelectedIndex];
                Ell.ResizeEll(int.Parse(new_width.Text), int.Parse(new_height.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Ellipse Ell = FiguresContainer.EllipsesList[comboBox1.SelectedIndex];
                FiguresContainer.EllipsesList.Remove(Ell);
                Ell.DeleteF(Ell, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < FiguresContainer.EllipsesList.Count; i++)
                {
                    comboBox1.Items.Add(FiguresContainer.EllipsesList[i]);
                    comboBox1.Items[i] = $"Ell{FiguresContainer.EllipsesList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
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
    }
}
