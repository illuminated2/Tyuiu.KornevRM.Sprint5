using System.IO;
using Tyuiu.KornevRM.Sprint5.Task7.V15.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

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
