using Tyuiu.EvdokimovKP.Sprint5.Task5.V29.Lib;

namespace Tyuiu.EvdokimovKP.Sprint5.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\evdok\AppData\Local\Temp\InPutDataFileTask5V29.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
