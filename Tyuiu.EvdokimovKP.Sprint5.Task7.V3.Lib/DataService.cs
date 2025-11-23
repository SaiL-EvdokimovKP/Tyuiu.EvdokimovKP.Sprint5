using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EvdokimovKP.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V3.txt" });

            FileInfo f = new FileInfo(pathSaveFile);
            if (f.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(Convert.ToChar(line[i]) >= 'а' && Convert.ToChar(line[i]) <= 'я' ||
                            Convert.ToChar(line[i]) >= 'А' && Convert.ToChar(line[i]) <= 'Я'))
                        {
                            strLine = strLine + line[i];
                        }
                        string strline = Regex.Replace(pathSaveFile, @"s+", "");
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }

            }
            return pathSaveFile;
        }
    }
}
