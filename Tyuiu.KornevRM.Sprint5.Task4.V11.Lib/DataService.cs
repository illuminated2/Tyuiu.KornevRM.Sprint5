using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KornevRM.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Convert.ToDouble(File.ReadAllText(path).Replace('.', ','));
            return res = Math.Round(Math.Sin(res) + (Math.Pow(res, 2) / 2), 3);
        }
    }
}
