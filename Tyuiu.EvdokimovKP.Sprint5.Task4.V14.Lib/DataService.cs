using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.EvdokimovKP.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");

            double x = Convert.ToDouble(strx);
            double res = Math.Round(Math.Sin(Math.Pow(x, 3)) + (2 / x),3);

            return res;
        }
    }
}
