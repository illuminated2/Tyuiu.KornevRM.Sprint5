using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KornevRM.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 3;

            try
            {
                string text = File.ReadAllText(path);
                string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word.Length == 4)
                    {
                        count++;
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }

            return count;
        }
    }
}
