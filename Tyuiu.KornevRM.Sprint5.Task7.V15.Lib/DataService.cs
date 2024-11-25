using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KornevRM.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");


            if (!File.Exists(pathSaveFile))
            {
                throw new FileNotFoundException("Файл не найден.", pathSaveFile);
            }

       
            var lines = File.ReadAllLines(pathSaveFile);
            var resultLines = lines.Select(line =>
                string.Join(" ", line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length != 2)));

        
            return string.Join(Environment.NewLine, resultLines).Trim();

        }
    }
}
