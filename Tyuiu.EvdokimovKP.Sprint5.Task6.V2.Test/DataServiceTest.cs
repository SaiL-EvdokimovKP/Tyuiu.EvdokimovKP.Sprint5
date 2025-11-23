using Tyuiu.EvdokimovKP.Sprint5.Task6.V2.Lib;
using System.IO;

namespace Tyuiu.EvdokimovKP.Sprint5.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\evdok\AppData\Local\Temp\InPutDataFileTask6V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
