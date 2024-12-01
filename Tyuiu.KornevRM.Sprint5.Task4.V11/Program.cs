using Tyuiu.KornevRM.Sprint5.Task4.V11.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V11.txt";
            Console.Title = "Спринт #5 | Выполнил: Корнев Р. М. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р. М. | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл InPutDataFileTask4V29.txt в котором есть вещественное значение *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле             *");
            Console.WriteLine("* y = sinx + x^2/2 Округлить до трёх знаков после запятой.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
