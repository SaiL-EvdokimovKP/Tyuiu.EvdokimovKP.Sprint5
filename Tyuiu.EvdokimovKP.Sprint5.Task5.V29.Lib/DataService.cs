using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EvdokimovKP.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double x;
            double y = 99;
            double z = -99;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace('.', ',').Trim();
                    if (double.TryParse(line, out x))
                    {
                        if (x >= 10)
                        {
                            if (x <= y)
                            {
                                y = x;
                            }
                        }
                        if (x <= -10)
                        {
                            if (x >= z)
                            {
                                z = x;
                            }
                        }
                        if (z == -99)
                            res = y;
                        else
                            res = z;
                    }
                }
            }
            return Convert.ToDouble(res);
        }
    }
}
