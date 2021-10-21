using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusAndLambda_Q5_10
{
    public class StudentList
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static void Remove(Student student)
        {
            students.Remove(student);
        }

        public static List<Student> Filter(FilterDelegate filterDelegate)
        {
            List<Student> filteredStudents = new List<Student>();

            foreach (var student in students)
            {
                if (filterDelegate(student))
                {
                    filteredStudents.Add(student);
                }
            }

            return filteredStudents;
        }

        public static bool Contain(ContainDelegate containDelegate)
        {
            foreach (var student in students)
            {
                if (containDelegate(student))
                {
                    return true;
                }
            }
            return false;
        }   

        public static int Sum(SumDelegate sumDelegate)
        {
            int counter = 0;
            foreach (var student in students)
            {
                counter += sumDelegate(student);
            }
            return counter;
        }

        public static decimal GetAverage(SumDelegate sum,  AverageDelegate averageDelegate)
        {
            int numOfStudents = students.Count;
            return averageDelegate(Sum(sum), numOfStudents);
        }
    }
}
