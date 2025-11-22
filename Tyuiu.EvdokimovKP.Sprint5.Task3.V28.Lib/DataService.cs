using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EvdokimovKP.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            string combine = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double y = -(1 / 4) * (Math.Pow(((double)x), 3) - (3 * (Math.Pow(((double)x), 2)) + 4));

            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(combine, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return combine;
        }
    }
}
