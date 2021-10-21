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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = StudentList.students;
        }

        public bool IsContainGradeHigherThan50(Student studet)
        {
            if (studet.Grade > 50) { return true; }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            SearchAndRemoveStudents searchAndRemoveStudents = new SearchAndRemoveStudents();
            searchAndRemoveStudents.Show(this);
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control1 = new ActionsControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(control1);
            control1.Dock = DockStyle.Fill;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control1 = new AddStudentsControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(control1);
            control1.Dock = DockStyle.Fill;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAndRemoveStudents searchAndRemoveStudents = new SearchAndRemoveStudents();
            searchAndRemoveStudents.Show(this);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(dataGridView1);
        }
    }
}
