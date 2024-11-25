using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KornevRM.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double max = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Файл не найден.", path);
                }

                string[] lines = File.ReadAllLines(path);
                double maxDivisibleBy10 = double.MinValue;

                foreach (var line in lines)
                {
                    // Разделяем строку на отдельные числа
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var numberStr in numbers)
                    {
                        if (double.TryParse(numberStr, out double number))
                        {
                            // Проверяем, является ли число целым и делится ли на 10
                            if (number % 10 == 0 && number % 1 == 0)
                            {
                                maxDivisibleBy10 = Math.Max(maxDivisibleBy10, number);
                            }
                        }
                    }
                }

                if (maxDivisibleBy10 == double.MinValue)
                {
                    throw new InvalidOperationException("Чисел, делящихся на 10, не найдено.");
                }

                return maxDivisibleBy10;
            }
        }
        
    }
}
