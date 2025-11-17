using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.EvdokimovKP.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            string combine = Path.Combine(Path.GetTempPath(), "OutPutFileTest0.txt");
            double y;
            y = Math.Pow((x - 1), (3 * x + 1));
            y = Math.Round(y, 2);
            File.WriteAllText(combine, Convert.ToString(y));
            return combine;
        }
    }
}