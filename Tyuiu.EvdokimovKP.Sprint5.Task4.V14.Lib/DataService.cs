using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.EvdokimovKP.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            double y = Math.Sin(Math.Pow(Convert.ToDouble(x), 3)) + (2 / Convert.ToDouble(x));
            return Math.Round(y, 3);
        }
    }
}
