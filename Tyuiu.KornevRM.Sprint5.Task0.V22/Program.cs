
using Tyuiu.KornevRM.Sprint5.Task0.V22.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
