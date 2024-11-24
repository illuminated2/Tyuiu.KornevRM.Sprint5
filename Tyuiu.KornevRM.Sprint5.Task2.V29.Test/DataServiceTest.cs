using Tyuiu.KornevRM.Sprint5.Task2.V29.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователи\iLLum\source\repos\Tyuiu.KornevRM.Sprint5\Tyuiu.KornevRM.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}