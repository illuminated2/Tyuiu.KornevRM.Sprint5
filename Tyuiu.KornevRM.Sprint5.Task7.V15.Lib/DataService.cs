using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KornevRM.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt"); 

            FileInfo fileinfo = new FileInfo(pathSaveFile);

            if (fileinfo.Exists)
            {
                File.Delete(pathSaveFile);
            }



            string text = File.ReadAllText(path);
            List<string> list = new List<string>();
            foreach (string word in text.Split(' '))
            {
                if (word.Length != 2)
                {
                    list.Add(word);
                }
                else
                {
                    list.Add("");
                }
            }

            File.AppendAllText(pathSaveFile, string.Join("", list));
            return pathSaveFile;


        }
    }
}
