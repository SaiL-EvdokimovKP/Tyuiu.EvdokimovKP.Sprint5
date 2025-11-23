using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EvdokimovKP.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double res = 100;
            string file = Path.GetTempFileName();
            File.WriteAllText(file, "1,79" + Environment.NewLine + "11" + Environment.NewLine + "3,6" + Environment.NewLine + "31");
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length == 2)
                    {
                        if (res > Convert.ToDouble(line))
                        {
                            res = Convert.ToDouble(line);
                        }
                    }
                }
            }
            return res;
        }
    }
}
