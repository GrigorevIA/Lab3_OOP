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
    public partial class Rect : Form
    {
        private Button but;
        public Rect(Button but)
        {
            InitializeComponent();
            this.but = but;
            for (int i = 0; i < FiguresContainer.RectsList.Count; i++)
            {
                comboBox1.Items.Add(FiguresContainer.RectsList[i]); 
                comboBox1.Items[i] = $"Rect{FiguresContainer.RectsList[i].number}";
            }
            buttonDelete.Enabled = false;
            Button_New_Cords.Enabled = false;
            Button_New_Size.Enabled = false;
        }
        private void FormRect_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
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
                Rectangle Rect = new Rectangle(int.Parse(setX.Text),int.Parse(setY.Text), 
                                               int.Parse(width.Text),int.Parse(height.Text));
                Rect.Draw();
                comboBox1.Items.Add(Rect); 
                comboBox1.Items[comboBox1.FindStringExact(Rect.ToString())] = $"Rect{Rect.number}";
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
                Rectangle Rect = FiguresContainer.RectsList[comboBox1.SelectedIndex];
                Rect.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
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
                Rectangle Rect = FiguresContainer.RectsList[comboBox1.SelectedIndex];
                Rect.ResizeRect(int.Parse(new_width.Text), int.Parse(new_height.Text));
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
                Rectangle Rect = FiguresContainer.RectsList[comboBox1.SelectedIndex];
                FiguresContainer.RectsList.Remove(Rect);
                Rect.DeleteF(Rect, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < FiguresContainer.RectsList.Count; i++)
                {
                    comboBox1.Items.Add(FiguresContainer.RectsList[i]);
                    comboBox1.Items[i] = $"Rect{FiguresContainer.RectsList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }
    }

}
