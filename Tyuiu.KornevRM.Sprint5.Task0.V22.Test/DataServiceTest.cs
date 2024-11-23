using Tyuiu.KornevRM.Sprint5.Task0.V22.Lib;
namespace Tyuiu.KornevRM.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователи\iLLum\source\repos\Tyuiu.KornevRM.Sprint5\Tyuiu.KornevRM.Sprint5.Task0.V22\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);
        }
    }
}