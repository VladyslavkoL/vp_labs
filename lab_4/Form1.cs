using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        private Config _config = null;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            _config = Config.GetConfig();
            Init();
        }
        private void Init()
        {
            if (!_config.IsNullProp())
            {
                textBox1.Text = _config.Alpha.ToString();
                textBox2.Text = _config.Radius.ToString();
                textBox3.Text = _config.ChordLength;
                textBox4.Text = _config.ArcLength;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // a = 2Rsin(a/2)  l = piR/180*alpha    
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Дані не введено!", "Помилка");
            }
            else
            {
                double alpha = double.Parse(textBox1.Text);
                if(alpha>180 || alpha < 0)
                {
                    MessageBox.Show("Кут повинен бути в межах [0;180]", "Помилка");
                    textBox1.Clear();
                    return;
                }
                double radius = double.Parse(textBox2.Text);
                textBox3.Text = string.Format("{0:F3}", 2*radius*Math.Sin((alpha * (Math.PI)) / 360));
                textBox4.Text = string.Format("{0:F3}", (radius * alpha / 180)) + "π";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else if (!textBox1.Text.Contains(",")&&(!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else if (!textBox2.Text.Contains(",")&&(!string.IsNullOrEmpty(textBox2.Text) && e.KeyChar == ','))
            {
                return;
            }
            e.Handled = true;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right-click is not allowed", "No Right-click");
                return;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isTextEmpty())
            {
                _config.Alpha = double.Parse(textBox1.Text);
                _config.Radius = double.Parse(textBox2.Text);
                _config.ChordLength = textBox3.Text;
                _config.ArcLength = textBox4.Text;
                _config.Save();
            }
            else
            {
                _config.Clear();
                _config.Save();
            }
           
        }
        private bool isTextEmpty()
        {
            return string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox1.Text);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
