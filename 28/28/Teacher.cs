using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Teacher
    {
        public Teacher(Student student)
        {
            student.GradeAdded += CheckGrades;
        }

        private void CheckGrades(object sender, string gradeAddedMessage)
        {
            Student student = (Student)sender;
            double averageGrade = student.GetAverageGrade();

            if (averageGrade <= 2.4 && averageGrade != -1)
            {
                Console.WriteLine("Предупреждение: Низкая успеваемость студента!");
            }

            Console.WriteLine(gradeAddedMessage);
        }
    }
}
