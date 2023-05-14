namespace PZ_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "source.txt";
            string parameterName = "myParameter";
            string replacement = "newParameterValue";

            try
            {
               
                string fileContent = File.ReadAllText(filePath);

                int startIndex = fileContent.IndexOf(parameterName);

                if (startIndex != -1)
                {
                    int endIndex = startIndex + parameterName.Length;
                    fileContent = fileContent.Substring(0, startIndex) + replacement + fileContent.Substring(endIndex);

                    File.WriteAllText(filePath, fileContent);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Файл не найден: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка ввода/вывода: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}