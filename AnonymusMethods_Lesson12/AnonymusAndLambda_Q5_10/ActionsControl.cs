using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymusAndLambda_Q5_10
{
    public partial class ActionsControl : UserControl
    {
        public ActionsControl()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        #region פונקציות שפתחתי בטעות

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        #endregion

        // function for question 5

        public bool FilterByGrade(Student student)
        {
            int grade = int.Parse(textBox1.Text);
            return student.Grade >= grade;
        }

        // function for question 7

        public bool ThereIsStudentsWithGradeMoreThan50(Student student)
        {
            return student.Grade > 50;
        }

        // function for question 8

        public bool ThereIsStudentWithSameFirstLetterInFirstAndLastName(Student student)
        {
            return student.FirstName[0] == student.LastName[0];
        }

        // functions for question 9

        public int TotalTuitionPaid(Student student)
        {
            return student.TiutionPaid;
        }

        public int TotalTuitionLeft(Student student)
        {
            return student.TiutionLeft;
        }

        // functions for question 10

        public int GetTotalAges(Student student)
        {
            return student.Age;
        }

        public int GetTotalGrades(Student student)
        {
            return student.Grade;
        }

        public decimal GetAverage(int sum, int numOfStudents)
        {
            return sum / numOfStudents;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Grade":
                    listBox1.Items.Clear();
                    var list = StudentList.Filter(FilterByGrade);
                    foreach (var item in list)
                    {
                        listBox1.Items.Add(item.FirstName + " " + item.LastName);
                    }
                    break;
                case "Tuition left to pay":
                    listBox1.Items.Clear();
                    int tuition = int.Parse(textBox1.Text);
                    foreach (var studet in StudentList.students)
                    {
                        if (studet.TiutionLeft >= tuition)
                        {
                            listBox1.Items.Add(studet.FirstName + " " + studet.LastName);
                        }
                    }
                    break;
                default:
                    break;
            }

        }


        private async void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Grade more than 50":
                    if (StudentList.Contain(ThereIsStudentsWithGradeMoreThan50))
                    {
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        pictureBox2.Visible = true;
                    }
                    break;

                case "Same first letter":
                    if (StudentList.Contain(ThereIsStudentWithSameFirstLetterInFirstAndLastName))
                    {
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        pictureBox2.Visible = true;
                    }

                    break;
                default:
                    break;
            }
            await Task.Delay(3000);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int paid = StudentList.Sum(TotalTuitionPaid);
            int left = StudentList.Sum(TotalTuitionLeft);

            textBox2.Text = paid.ToString();
            textBox3.Text = left.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "Grades":
                    textBox4.Text = StudentList.GetAverage(GetTotalGrades, GetAverage).ToString();
                    break;

                case "Ages":
                    textBox4.Text = StudentList.GetAverage(GetTotalAges, GetAverage).ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
