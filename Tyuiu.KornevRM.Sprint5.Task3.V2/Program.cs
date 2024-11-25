using Tyuiu.KornevRM.Sprint5.Task3.V2.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + ds.SaveToFileTextData(x));
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}
