using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudensManagement_HW_Q5_10
{
    public partial class AddStudentsControl1 : UserControl
    {
        public AddStudentsControl1()
        {
            InitializeComponent();
        }

        private void ApplyBut_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string fName = textBox2.Text;
            string lName = textBox3.Text;
            int age = int.Parse(textBox4.Text);
            int paid = int.Parse(textBox5.Text);
            int left = int.Parse(textBox6.Text);
            int grade = int.Parse(textBox7.Text);

            Student student = new Student(id, fName, lName, age, paid, left, grade);
            StudentList.AddStudent(student);
            MessageBox.Show("Student Added Successfuly");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {

        }
    }
}
