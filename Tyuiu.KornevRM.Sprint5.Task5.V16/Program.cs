using Tyuiu.KornevRM.Sprint5.Task5.V16.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Корнев Р. М. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р. М. | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл InPutDataFileTask5V24.txt в котором есть набор значений.       *");
            Console.WriteLine("* Найти сумму всех двузначных целых чисел в файле.  Полученный            *");
            Console.WriteLine("* результат вывести на консоль. У вещественных значений округлить         *");
            Console.WriteLine("* до трёх знаков после запятой.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("**************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Максимальное целое число в файле, которое делится на 10 = " + res);
            Console.ReadKey();
        }
    }
}
