namespace _27
{
    internal class Program
    {
        struct STUDENT
        {
            public string NAME;
            public int GROUP;
            public double[] SES;
        }
        static void Main(string[] args)
        {
            const int N = 10; // количество студентов

            STUDENT[] STUD1 = new STUDENT[N];

            // Ввод данных для массива структур
            Console.WriteLine("Введите данные студентов:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Студент {i + 1}:\n  Фамилия и инициалы: ");
                STUD1[i].NAME = Console.ReadLine();
                Console.Write("  Номер группы: ");
                STUD1[i].GROUP = int.Parse(Console.ReadLine());
                Console.WriteLine("  Оценки (через пробел): ");
                string[] s = Console.ReadLine().Split();
                STUD1[i].SES = new double[5];
                for (int j = 0; j < 5; j++)
                {
                    STUD1[i].SES[j] = double.Parse(s[j]);
                }
            }

            // Сортировка по номеру группы
            Array.Sort(STUD1, (x, y) => x.GROUP.CompareTo(y.GROUP));

            // Вывод данных о студентах
            Console.WriteLine("\nСтуденты со средним баллом больше 4.0:");
            bool flag = false;
            for (int i = 0; i < N; i++)
            {
                double avg = 0;
                for (int j = 0; j < 5; j++)
                {
                    avg += STUD1[i].SES[j];
                }
                avg /= 5;
                if (avg > 4.0)
                {
                    Console.WriteLine($"{STUD1[i].NAME}, группа {STUD1[i].GROUP}");
                    flag = true;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Студентов со средним баллом больше 4.0 нет");
            }

            Console.ReadKey();
        }
    }
}
       