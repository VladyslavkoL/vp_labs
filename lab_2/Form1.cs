using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_2
{
    public partial class Form1 : Form
    {
        double A, B, K;
        double x, y, y_2;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (chart2.Series.Count != 0&& chart3.Series.Count != 0)
            {
                chart2.SaveImage("explict_chart1.png", ChartImageFormat.Png);
                chart3.SaveImage("explict_chart2.png", ChartImageFormat.Png);
                using (TextWriter sw = new StreamWriter("chart2.txt"))
                {
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            sw.Write("\t" + dataGridView2.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        sw.WriteLine("");
                        sw.WriteLine("-----------------------------------------------------");
                    }
                    sw.Close();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            if(chart1.Series.Count != 0)
            {
                chart1.SaveImage("explict_chart.png", ChartImageFormat.Png);
                using(TextWriter sw = new StreamWriter("chart1.txt"))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            sw.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        sw.WriteLine("");
                        sw.WriteLine("-----------------------------------------------------");
                    }
                    sw.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                chart2.Series[0].Points.Clear();
                if (string.IsNullOrWhiteSpace(textBox4.Text)
                    || string.IsNullOrWhiteSpace(textBox5.Text)
                    || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Ви не заповнили всі поля", "Помилка");
                }
                A = double.Parse(textBox6.Text);
                B = double.Parse(textBox5.Text);
                K = double.Parse(textBox4.Text);
                x = A;
                int index = 0;
                while (x < B)
                {
                    y = Math.Pow(x + 1, 2) / 4;
                    y_2 = Math.Pow(x - 1, 2) / 4;
                    if (y < 20 && y > -20 && y_2 < 20 && y_2 > -20)
                    {

                        chart3.Series[0].Points.AddXY(x, y);
                        chart3.Series[1].Points.AddXY(x, y_2);
                    }
                    if (y_2 / y < 20 && y_2 / y > -20 && y / y_2 < 20 && y / y_2 > -20)
                    {
                        chart2.Series[0].Points.AddXY(x, y_2 / y);
                        chart2.Series[1].Points.AddXY(x, y / y_2);
                    }

                    if (!Double.IsNaN(y) || !Double.IsNaN(y_2))
                    {
                        dataGridView2.Rows.Add(y,y_2, x);
                        dataGridView2.Rows[index].HeaderCell.Value = (++index).ToString();
                    }
                    
                    x += (B - A) / K;
                }         
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender; 
            if (char.IsDigit(e.KeyChar)||e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else if ((e.KeyChar == '.' && !string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains(".") && textBox.Text != "-"))
            {
                return;
            }
            else if ((e.KeyChar == '-' && string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains("-")))
            {
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();
                
                if (string.IsNullOrWhiteSpace(textBox1.Text) 
                    || string.IsNullOrWhiteSpace(textBox2.Text) 
                    || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Ви не заповнили всі поля", "Помилка");
                }
                A = double.Parse(textBox1.Text);
                B = double.Parse(textBox2.Text);
                K = double.Parse(textBox3.Text);
                x = A;
                int index = 0;
                while (x < B)
                {
                    if (x != 1 && x != -1)
                    {
                        y = Math.Exp(1 / (1 - Math.Pow(x, 2))) / (1 + Math.Pow(x, 2));
                        if (y <= 100)
                        {
                            chart1.Series[0].Points.AddXY(x, y);
                        }
                    }
                    else
                    {
                        y = 0;
                    }
                    if (!Double.IsNaN(y))
                    {
                        dataGridView1.Rows.Add(y, x);
                        dataGridView1.Rows[index].HeaderCell.Value = (++index).ToString();
                    }
                    else
                    {
                        dataGridView1.Rows.Add('-', '-');
                        dataGridView1.Rows[index].HeaderCell.Value = (++index).ToString();
                    }
                    x += (B - A) / K;
                }
            }
            catch { }
        }
    }
}
