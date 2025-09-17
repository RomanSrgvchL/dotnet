using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Clear();

            String text = "";

            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                if (i == numericUpDown1.Value)
                {
                    text += i.ToString();
                }
                else
                {
                    text += i.ToString() + " ";
                }
            }

            textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
            comboBox1.Items.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private Boolean chechNumsInCalc()
        {
            if (!(Double.TryParse(textBox4.Text, out _) &&
                Double.TryParse(textBox5.Text, out _)))
            {
                MessageBox.Show("Операция применима только к вещественным числам", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chechNumsInCalc())
            {
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) + 
                    Convert.ToDouble(textBox5.Text));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chechNumsInCalc())
            {
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) -
                    Convert.ToDouble(textBox5.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chechNumsInCalc())
            {
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) *
                    Convert.ToDouble(textBox5.Text));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (chechNumsInCalc())
            {
                double textBox5Num = Convert.ToDouble(textBox5.Text);

                if (Math.Abs(textBox5Num) < 0.00000000000000000001)
                {
                    MessageBox.Show("Делить на ноль нельзя", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) / 
                        Convert.ToDouble(textBox5.Text));
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            String[] lines = textBox7.Text.Split(new char[] {'\n'});

            for (int i = 0; i < lines.Length; i++)
            {
                String line = lines[i];
                 
                if (Double.TryParse(line, out _))
                {
                    comboBox2.Items.Add(lines[i]);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Clear();

            int x = 1;
            double sum = 0;
            double limit = Convert.ToDouble(numericUpDown2.Value);

            while (true)
            {
                sum += 1.0 / x;

                textBox8.Text += sum + "\r\n";

                if (1.0 / x < limit)
                {
                    textBox8.Text += "\r\nСумма ряда:\r\n" + sum + "\r\n";
                    break;
                }

                x++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String[] lines = textBox9.Text.Split(new char[] { '\n' });

            String result = "";

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                String line = lines[i];

                if (!Double.TryParse(line, out _))
                {
                    result += line;

                    if (i != 0)
                    {
                        result += "\n";
                    }
                }
            }

            textBox10.Text = result;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Double a, b, h;

            if (!(Double.TryParse(textBox11.Text, out a) &&
              Double.TryParse(textBox12.Text, out b) &&
              Double.TryParse(textBox13.Text, out h)))
            {
                MessageBox.Show("Переменные a, b и h должны быть числами", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (h > 0)
                {
                    if (a <= b)
                    {
                        String result = "";

                        for (double x = a; x <= b; x += h)
                        {
                            double f = Math.Sin(x) / (Math.Abs(x) + 1);

                            result += "x = " + Math.Round(x, 3) + " ; f(x) = " + Math.Round(f, 3);

                            if (a <= b)
                            {
                                result += "\r\n";
                            }
                        }

                        textBox14.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("a должно быть меньше b", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } 
                else
                {
                    MessageBox.Show("Шаг h должен быть положительным", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}