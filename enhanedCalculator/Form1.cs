using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enhanedCalculator
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
                int number1 = int.Parse(textBox1.Text);

                int number2 = int.Parse(textBox2.Text);

                int result = number1 + number2;

                label3.Text = result.ToString();
            }
            catch 
            {
                string message = "حدث خطأ ما  ";

                string title = "تنبيه";
                MessageBox.Show(message , title);

            }
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int number1 = int.Parse(textBox1.Text);

                int number2 = int.Parse(textBox2.Text);

                int result = number1 - number2;

                label3.Text = result.ToString();
            }
            catch
            {
                string message = "حدث خطأ ما  ";

                string title = "تنبيه";
                MessageBox.Show(message, title);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int number1 = int.Parse(textBox1.Text);

                int number2 = int.Parse(textBox2.Text);

                int result = number1 * number2;

                label3.Text = result.ToString();
            }
            catch
            {
                string message = "حدث خطأ ما  ";

                string title = "تنبيه";
                MessageBox.Show(message, title);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int number1 = int.Parse(textBox1.Text);

                int number2 = int.Parse(textBox2.Text);

                int result = number1 / number2;

                label3.Text = result.ToString();
            }
            catch
            {
                string message = "حدث خطأ ما  ";

                string title = "تنبيه";
                MessageBox.Show(message, title);

            }
        }
    }
}
