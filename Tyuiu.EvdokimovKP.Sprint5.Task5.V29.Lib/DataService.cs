using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EvdokimovKP.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            string strx=File.ReadAllText(path);
            strx = strx.Replace('.', ',');
            string[] strings = strx.Split(' ');
            double min = 99999999;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    if (Convert.ToDouble(strings[i])<min && Convert.ToDouble(strings[i])>=10 && Convert.ToDouble(strings[i]) <= 99)
                    {
                        min = Convert.ToDouble(strings[i]);
                    }

                }
                
                
            }
            return min;
            
        }
    }
}