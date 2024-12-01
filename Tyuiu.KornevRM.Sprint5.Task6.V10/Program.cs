using Tyuiu.KornevRM.Sprint5.Task6.V10.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Корнев Р. М. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р. М. | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл InPutDataFileTask6V4.txt в котором есть набор символьных       *");
            Console.WriteLine("* данных. Найти количество слов длиной четыре символа в заданной строке.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";

            Console.WriteLine("Данные находятся в файле" + path);


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма слов длинной 4 символа = " + res);
            Console.ReadKey();
        }
    }
}
