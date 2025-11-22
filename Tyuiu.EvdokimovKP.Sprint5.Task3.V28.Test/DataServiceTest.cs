using Microsoft.ApplicationInsights;
using Tyuiu.EvdokimovKP.Sprint5.Task3.V28.Lib;

namespace Tyuiu.EvdokimovKP.Sprint5.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            string combine = ds.SaveToFileTextData(x);
            FileInfo fileinfo = new FileInfo(combine);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
