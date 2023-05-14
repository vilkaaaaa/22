using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Student
    {
        private int[] grades;
        private double averageGrade = -1.0;

        public event EventHandler<string> GradeAdded;

        public void AddGrade(int grade)
        {
            if (grades == null)
            {
                grades = new int[] { grade };
            }
            else
            {
                int[] newGrades = new int[grades.Length + 1];
                Array.Copy(grades, newGrades, grades.Length);
                newGrades[newGrades.Length - 1] = grade;
                grades = newGrades;
            }

            CalculateAverageGrade();
            GradeAdded?.Invoke(this, $"Добавлена оценка: {grade}");
            Console.WriteLine($"Средний балл ученика: {Math.Round(averageGrade, 2)}");
        }

        private void CalculateAverageGrade()
        {
            if (grades != null && grades.Length > 0)
            {
                double sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                }
                averageGrade = sum / grades.Length;
            }
            else
            {
                averageGrade = 0.0;
            }
        }

        public double GetAverageGrade()
        {
            return averageGrade;
        }
    }
}
