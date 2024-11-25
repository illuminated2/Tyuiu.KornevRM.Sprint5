using Tyuiu.KornevRM.Sprint5.Task6.V10.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

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
