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
    public partial class Round : Form
    {
        private Button but;
        public Round(Button but)
        {
            InitializeComponent();
            this.but = but;
            for (int i = 0; i < FiguresContainer.RoundsList.Count; i++)
            {
                comboBox1.Items.Add(FiguresContainer.RoundsList[i]);
                comboBox1.Items[i] = $"Ro{FiguresContainer.RoundsList[i].number}";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Round Ro = FiguresContainer.RoundsList[comboBox1.SelectedIndex];
                FiguresContainer.RoundsList.Remove(Ro);
                Ro.DeleteF(Ro, true);
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < FiguresContainer.RoundsList.Count; i++)
                {
                    comboBox1.Items.Add(FiguresContainer.RoundsList[i]);
                    comboBox1.Items[i] = $"Ro{FiguresContainer.RoundsList[i].number}";
                }
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
                MyFigures.Round Ro = FiguresContainer.RoundsList[comboBox1.SelectedIndex];
                Ro.MoveTo(int.Parse(new_X.Text), int.Parse(new_Y.Text));
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
                MyFigures.Round Ro = FiguresContainer.RoundsList[comboBox1.SelectedIndex];
                Ro.ResizeRound(int.Parse(new_width.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }
        private void FormRounds_MouseDown(object sender, MouseEventArgs e)
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

        private void Button_Draw_Click(object sender, EventArgs e)
        {
            try
            {
                MyFigures.Round Ro = new MyFigures.Round(int.Parse(setX.Text), int.Parse(setY.Text),
                                               int.Parse(width.Text));
                Ro.Draw();
                comboBox1.Items.Add(Ro);
                comboBox1.Items[comboBox1.FindStringExact(Ro.ToString())] = $"Ro{Ro.number}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ашипка");
            }
        }
    }
}

