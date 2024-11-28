using System.IO;
using Tyuiu.KornevRM.Sprint5.Task7.V15.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Корнев Р.М.  |  ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл InPutDataFileTask7V15.txt в котором есть набор символьных      *");
            Console.WriteLine("* данных.  Заменить все заглавные латинские буквы на строчные.            *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V10.txt.       *");
            Console.WriteLine("*                                                                         *");
            string path = @"C:\DataSprint5\InPutDataFileTask7V15.txt";
            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Data in " + path);
            Console.WriteLine("The result in " + pathSaveFile);
            Console.ReadKey();
        }
    }
}
