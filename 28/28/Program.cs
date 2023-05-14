namespace _28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher(student);

            while (true)
            {
                Console.Write("Введите оценку студента: ");
                int input = Convert.ToInt32(Console.ReadLine());
                student.AddGrade(input);
            }

        }
    }
}