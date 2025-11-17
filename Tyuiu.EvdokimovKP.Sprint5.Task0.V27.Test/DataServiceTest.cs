using Tyuiu.EvdokimovKP.Sprint5.Task0.V27.Lib;
using System.IO;


namespace Tyuiu.EvdokimovKP.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string combine = ds.SaveToFileTextData(3);
            FileInfo fileinfo = new FileInfo(combine);
            bool fileExist = fileinfo.Exists;
            bool wait = true; 
            Assert.AreEqual(wait, fileExist);
        }
    }
}