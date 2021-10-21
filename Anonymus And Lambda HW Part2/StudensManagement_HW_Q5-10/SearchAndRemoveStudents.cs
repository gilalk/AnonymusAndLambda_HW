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
    public partial class SearchAndRemoveStudents : Form
    {
        public SearchAndRemoveStudents()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = textBox1.Text;
                bool exist = false;
                if (textBox1 == null) { MessageBox.Show("First enter ID!"); }
                textBox1.ReadOnly = true;
                foreach (var student in StudentList.students)
                {
                    if (student.Id == int.Parse(ID))
                    {
                        propertyGrid1.SelectedObject = student;
                        exist = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        break;
                    }
                }

                if (!exist)
                {
                    textBox1.ReadOnly = false;
                    MessageBox.Show("ID Not Found!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (propertyGrid1.SelectedObject == null) { MessageBox.Show("First search student!"); }
            foreach (var student in StudentList.students)
            {
                if (textBox1.Text == student.Id.ToString())
                {
                    StudentList.Remove(student);
                    break;
                }
            }
            propertyGrid1.SelectedObject = null;
            textBox1.ReadOnly = false;
            textBox1.Clear();
            MessageBox.Show("Student deleted!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = null;
            textBox1.ReadOnly = false;
            MessageBox.Show("Student Updated");
        }
    }
}
