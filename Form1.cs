using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ZyryanovAA.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox3.Text);

                if (radioButton1.Checked)
                {
                    double result = Math.Pow((1 + (1 / Math.Pow(x, 2))), x) - 12 * (Math.Pow(x, 2)) * y;
                    textBox2.Text = Convert.ToString(Math.Round(result, 3));
                }
                else if (radioButton2.Checked)
                {
                    double result = Math.Sin(Math.Sqrt(Math.Pow(x, 2))) + Math.Cos(Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) - Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1));
                    textBox2.Text = Convert.ToString(Math.Round(result, 3));
                }
                else
                {
                    MessageBox.Show("Для проведения расчётов\nнеобходимо выбрать\nхотя бы одной уравнение!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Во время расчётов произошла ошибка!\nПроверьте введённые данные!\nВыполните проверку деления на ноль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы НТм-22-1\t\nЗырянов Алексей Андреевич\t", "Разработчик", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
