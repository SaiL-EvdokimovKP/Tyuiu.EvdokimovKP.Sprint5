using Tyuiu.EvdokimovKP.Sprint5.Task1.V26.Lib;
using System.IO;


namespace Tyuiu.EvdokimovKP.Sprint5.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string combine = ds.SaveToFileTextData(-5, 5);
            FileInfo fileinfo = new FileInfo(combine);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}