using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_Form_HW_Lesson8
{
    public partial class Form1 : Form
    {

        int Add(int x, int y)
        {
            return x + y;
        }

        int Sub(int x, int y)
        {
            return x - y;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            MathActions pointers = Add;
            textBox3.Text = pointers(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            //textBox1.Clear();
            //textBox2.Clear();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            MathActions pointers = Sub;
            textBox3.Text = pointers(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
