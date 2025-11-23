using System.IO;
using Tyuiu.EvdokimovKP.Sprint5.Task4.V14.Lib;

namespace Tyuiu.EvdokimovKP.Sprint5.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\evdok\Desktop\DataSprint5\InPutDataFileTask4V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
