using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EvdokimovKP.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string combine = Path.Combine(Path.GetTempPath(), "OutPutFileTest1.txt");

            FileInfo fileinfo = new FileInfo(combine);
            bool fileExist = fileinfo.Exists;

            if (fileExist)
            {
                File.Delete(combine);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((((2 * x) + 6) / (Math.Cos(x) + x)) - 3, 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(combine, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(combine, strY);
                }
            }
            return combine;
        }
    }
}
