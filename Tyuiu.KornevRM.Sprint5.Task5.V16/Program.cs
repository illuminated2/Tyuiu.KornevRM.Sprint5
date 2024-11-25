using Tyuiu.KornevRM.Sprint5.Task5.V16.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Максимальное целое число в файле, которое делится на 10 = " + res);
            Console.ReadKey();
        }
    }
}
