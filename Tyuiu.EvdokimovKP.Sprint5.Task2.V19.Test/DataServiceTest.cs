using Tyuiu.EvdokimovKP.Sprint5.Task2.V19.Lib;

namespace Tyuiu.EvdokimovKP.Sprint5.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = new int[,] { { 9, 2, 5 },
                                         { 8, 8, 2 }, 
                                         { 7, 4, 8} };
            DataService ds = new DataService();
            string combine = ds.SaveToFileTextData(matrix);
            FileInfo fileinfo = new FileInfo(combine);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
