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
    public partial class RAKETA : Form
    {
        private Button but;
        public RAKETA(Button but)
        {
            InitializeComponent();
            this.but = but;
            for (int i = 0; i < FiguresContainer.RocketsList.Count; i++)
            {
                comboBox1.Items.Add(FiguresContainer.RocketsList[i]);
                comboBox1.Items[i] = $"Rocket{FiguresContainer.RocketsList[i].number}";
            }
            buttonDelete.Enabled = false;
            Button_New_Cords.Enabled = false;
            Button_New_Size.Enabled = false;
        }
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
        }

        private void Button_Draw_Click(object sender, EventArgs e)
        {
            try
            {
                Rocket Rocket = new Rocket(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text), int.Parse(height.Text));
                Rocket.Draw();
                comboBox1.Items.Add(Rocket);
                comboBox1.Items[comboBox1.FindStringExact(Rocket.ToString())] = $"Rocket{Rocket.number}";
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
                Rocket Rocket = FiguresContainer.RocketsList[comboBox1.SelectedIndex];
                Rocket.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
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
                Rocket Rocket = FiguresContainer.RocketsList[comboBox1.SelectedIndex];
                Rocket.ResizeRocket(int.Parse(new_width.Text), int.Parse(new_height.Text));
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
                Rocket Rocket = FiguresContainer.RocketsList[comboBox1.SelectedIndex];
                FiguresContainer.RocketsList.Remove(Rocket);
                Rocket.DeleteF(Rocket, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < FiguresContainer.RocketsList.Count; i++)
                {
                    comboBox1.Items.Add(FiguresContainer.RocketsList[i]);
                    comboBox1.Items[i] = $"Rocket{FiguresContainer.RocketsList[i].number}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }
    }
}
