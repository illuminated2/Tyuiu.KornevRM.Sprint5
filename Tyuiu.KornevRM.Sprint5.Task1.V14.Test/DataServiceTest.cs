using Tyuiu.KornevRM.Sprint5.Task1.V14.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователи\iLLum\source\repos\Tyuiu.KornevRM.Sprint5\Tyuiu.KornevRM.Sprint5.Task1.V14\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}