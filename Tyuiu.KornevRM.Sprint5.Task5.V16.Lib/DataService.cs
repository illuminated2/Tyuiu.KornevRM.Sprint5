using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KornevRM.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double max = double.MinValue;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 10 == 0 && Convert.ToDouble(line) > max)
                    {
                        max = Convert.ToDouble(line);
                    }
                }
                return max;
            }
        }
    }
}
